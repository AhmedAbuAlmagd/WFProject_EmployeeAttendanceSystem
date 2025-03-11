using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAttendanceSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class isLate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
       name: "IsLate",
        table: "Attendances");
            migrationBuilder.AddColumn<string>(
                name: "IsLate",
                table: "Attendances",
                type: "nvarchar",
                nullable: false,
                defaultValue: false
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
               name: "IsEarlyDeparture",
               table: "Attendances");

            migrationBuilder.AddColumn<bool>(
                name: "IsLate",
                table: "Attendances",
                type: "nvarchar",
                nullable: false,
                defaultValue: false
            );
        }
    }
}
