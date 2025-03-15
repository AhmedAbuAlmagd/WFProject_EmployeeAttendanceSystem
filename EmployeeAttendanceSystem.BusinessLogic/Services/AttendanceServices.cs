using EmployeeAttendanceSystem.DataAccess.Context;
using EmployeeAttendanceSystem.DataAccess.Models;
using EmployeeAttendanceSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAttendanceSystem.BusinessLogic.Services
{
    public class AttendanceServices
    {
        private readonly AttendanceContext context;

        public AttendanceServices(AttendanceContext context)
        {
            this.context = context;
        }

        public List<Attendance> GetAll()
        {
            return context.Attendances.ToList();
        }

        public Attendance GetByEmployeeIdAndDate(int employeeId, DateOnly date)
        {
            return context.Attendances.FirstOrDefault(x => x.Employee_id == employeeId && x.Date == date);
        }

        public List<DateOnly> GetAllDates()
        {
            return context.Attendances.Select(e => e.Date).Distinct().ToList();
        }

        public List<Attendance> GetAttendanceByEmployee(int empId)
        {
            return context.Attendances
                .Where(e => e.Employee_id == empId)
                .Include(e => e.Employee)
                .ToList();
        }

        public List<Attendance> GetAttendanceByDate(DateOnly date)
        {
            return context.Attendances
                .Where(e => e.Date == date)
                .Include(e => e.Employee)
                .ToList();
        }

        public List<Attendance> GetAttendanceByEmpIdAndDate(int empId, DateOnly startDate, DateOnly endDate)
        {
            return context.Attendances
                .Where(e => e.Employee_id == empId && e.Date >= startDate && e.Date <= endDate)
                .Include(e => e.Employee)
                .ToList();
        }

        public List<Attendance> GetAttendanceByEmpIdAndDateOnly(int empId, DateOnly date)
        {
            return context.Attendances
                .Where(e => e.Employee_id == empId && e.Date == date)
                .Include(e => e.Employee)
                .ToList();
        }

        public void Add(Attendance attendance)
        {
            context.Attendances.Add(attendance);
            context.SaveChanges();
        }

        public void CreateDailyAttendanceRecords()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var yesterday = today.AddDays(-1);

            var unattendedCheckouts = context.Attendances
                .Where(a => a.Date == yesterday && a.checkInTime.HasValue && !a.checkOutTime.HasValue)
                .ToList();

            foreach (var record in unattendedCheckouts)
            {
                record.attendanceStatus = AttendanceStatus.Absent;
            }

            context.SaveChanges();

            var employees = context.Employees.Where(e => e.User.role.ToString() != "Admin").ToList();

            foreach (var employee in employees)
            {
                bool isWorkingDay = IsWorkingDay(employee.workSchedule.ToString(), today);

                if (isWorkingDay)
                {
                    var existingRecord = GetByEmployeeIdAndDate(employee.id, today);

                    if (existingRecord == null)
                    {
                        var attendance = new Attendance
                        {
                            Employee_id = employee.id,
                            Date = today,
                            checkInTime = null,
                            checkOutTime = null,
                            WorkingHours = null,
                            attendanceStatus = AttendanceStatus.Absent,
                            IsLate = false,
                            IsEarlyDeparture = false
                        };
                        context.Attendances.Add(attendance);
                    }
                }
            }

            context.SaveChanges();
        }

        public void CheckIn(int employeeId)
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var employee = context.Employees.FirstOrDefault(e => e.id == employeeId);

            if (employee == null)
                throw new InvalidOperationException("Employee not found.");

            bool isWorkingDay = IsWorkingDay(employee.workSchedule.ToString(), today);
            if (!isWorkingDay)
                throw new InvalidOperationException("Today is not a working day for you.");

            var now = TimeOnly.FromDateTime(DateTime.Now);
            var checkInStart = new TimeOnly(8, 0, 0);
            var checkInEnd = new TimeOnly(10, 0, 0);
            if (now < checkInStart || now > checkInEnd)
                throw new InvalidOperationException("Check-in is only allowed between 8 AM and 10 AM.");

            var attendance = GetByEmployeeIdAndDate(employeeId, today);
            var checkInTime = now;

            if (attendance == null)
            {
                attendance = new Attendance
                {
                    Employee_id = employeeId,
                    Date = today,
                    checkInTime = checkInTime,
                    attendanceStatus = AttendanceStatus.Present,
                    IsLate = checkInTime > new TimeOnly(9, 0, 0)
                };
                context.Attendances.Add(attendance);
            }
            else
            {
                if (attendance.checkInTime.HasValue)
                    throw new InvalidOperationException("You have already checked in today.");

                attendance.checkInTime = checkInTime;
                attendance.attendanceStatus = AttendanceStatus.Present;
                attendance.IsLate = checkInTime > new TimeOnly(9, 0, 0);
            }

            context.SaveChanges();
        }

        private bool IsWorkingDay(string workSchedule, DateOnly date)
        {
            var dayOfWeek = date.DayOfWeek;
            switch (workSchedule)
            {
                case "fullTime":
                case "remote":
                    return dayOfWeek != DayOfWeek.Friday && dayOfWeek != DayOfWeek.Saturday;
                case "partTimeG1":
                    return dayOfWeek == DayOfWeek.Sunday || dayOfWeek == DayOfWeek.Tuesday || dayOfWeek == DayOfWeek.Thursday;
                case "partTimeG2":
                    return dayOfWeek == DayOfWeek.Tuesday || dayOfWeek == DayOfWeek.Wednesday || dayOfWeek == DayOfWeek.Thursday;
                default:
                    return false;
            }
        }

        public void CheckOut(int employeeId)
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var attendance = GetByEmployeeIdAndDate(employeeId, today);

            if (attendance == null)
                throw new InvalidOperationException("No attendance record found for today.");

            if (!attendance.checkInTime.HasValue)
                throw new InvalidOperationException("You haven’t checked in today.");

            if (attendance.checkOutTime.HasValue)
                throw new InvalidOperationException("You have already checked out today.");

            var now = TimeOnly.FromDateTime(DateTime.Now);
            attendance.checkOutTime = now;
            attendance.WorkingHours = (int?)((now - attendance.checkInTime.Value).TotalHours);
            attendance.IsEarlyDeparture = now < new TimeOnly(17, 0, 0);

            context.SaveChanges();
        }

        public List<Attendance> GetDailyAttendance(DateOnly date)
        {
            return context.Attendances
                .Where(a => a.Date == date)
                .Include(a => a.Employee)
                .ToList();
        }

        public List<Attendance> GetMonthlyAttendance(int year, int month, int empId)
        {
            return context.Attendances
                .Where(a => a.Date.Year == year && a.Date.Month == month && a.Employee_id == empId)
                .Include(a => a.Employee)
                .ToList();
        }

        public List<Employee> GetFrequentAbsentees(DateOnly startDate, DateOnly endDate, int absenceNo)
        {
            return context.Employees
                .Where(e => e.Attendances.Count(a => a.Date >= startDate && a.Date <= endDate && a.attendanceStatus == AttendanceStatus.Absent) >= absenceNo)
                .ToList();
        }
    }
}
