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
                   v => v ? "t" : "f", // Convert bool to string
                   v => v == "t" // Convert string to bool
                );

            modelBuilder.Entity<Attendance>()
                .Property(a => a.IsEarlyDeparture)
                .HasConversion(
                    v => v ? "t" : "f", // Convert bool to string
                    v => v == "t" // Convert string to bool
                );

     
            modelBuilder.Entity<LeaveRequest>()
                .Property(r => r.LeaveType)
                .HasConversion(
                    v => v.ToString().Replace("_", " "), // Enum to string
                    v => (LeaveType)Enum.Parse(typeof(LeaveType), v.Replace(" ", "_")) // String to enum
                );
        
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<LeaveRequest> LeaveRequests { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
