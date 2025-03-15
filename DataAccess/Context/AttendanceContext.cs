using System.Configuration;
using EmployeeAttendanceSystem.DataAccess.Models;
using EmployeeAttendanceSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAttendanceSystem.DataAccess.Context
{
    public class AttendanceContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(ConfigurationManager.ConnectionStrings["EmployeeDbContext"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .Property(a => a.WorkingHours)
                .HasComputedColumnSql("DATEDIFF(SECOND, CAST(checkInTime AS DATETIME), CAST(checkOutTime AS DATETIME)) / 3600", stored: true);

            modelBuilder.Entity<Attendance>()
                .Property(a => a.IsLate)
                .HasConversion(
                   v => v ? "t" : "f", 
                   v => v == "t" 
                );

            modelBuilder.Entity<Attendance>()
                .Property(a => a.IsEarlyDeparture)
                .HasConversion(
                    v => v ? "t" : "f", 
                    v => v == "t" 
                );

     
            modelBuilder.Entity<LeaveRequest>()
                .Property(r => r.LeaveType)
                .HasConversion(
                    v => v.ToString().Replace("_", " "), 
                    v => (LeaveType)Enum.Parse(typeof(LeaveType), v.Replace(" ", "_")) 
                );

            modelBuilder.Entity<User>().HasData(
               new User
               {
                   id = 1,
                   userName = "admin",
                   password = "Admin@123", 
                   role = role.Admin,
                   employeeId = null
               },
               new User
               {
                   id = 2,
                   userName = "hrmanager",
                   password = "HR@123", 
                   role = role.HR,
                   employeeId = null
               } ,
               new User
               {
                   id = 3,
                   userName = "employee1",
                   password = "Employee@123", 
                   role = role.Employee,
                   employeeId = null
               }
           );
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<LeaveRequest> LeaveRequests { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
