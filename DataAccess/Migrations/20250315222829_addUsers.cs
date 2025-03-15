using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeAttendanceSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] {  "employeeId", "password", "role", "userName" },
                values: new object[,]
                {
                    {  null, "Admin@123", "Admin", "admin" },
                    { null, "HR@123", "HR", "hrmanager" },
                    { null, "Employee@123", "Employee", "employee1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2000);   
            
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3000);
        }
    }
}
