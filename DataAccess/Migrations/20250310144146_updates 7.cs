using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAttendanceSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updates7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
         name: "IsEarlyDeparture",
          table: "Attendances");
            migrationBuilder.AddColumn<string>(
                name: "IsEarlyDeparture",
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
                name: "IsEarlyDeparture",
                table: "Attendances",
                type: "bit",
                nullable: false,
                defaultValue: false
            );
        }
    }
}
