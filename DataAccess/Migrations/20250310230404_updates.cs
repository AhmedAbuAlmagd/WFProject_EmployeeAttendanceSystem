using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAttendanceSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            // Recreate the table with the new schema
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    requestDate = table.Column<DateTime>(nullable: false),
                    LeaveStartTime = table.Column<DateTime>(nullable: false),
                    LeaveEndTime = table.Column<DateTime>(nullable: false),
                    requestStatus = table.Column<string>(type: "nvarchar(50)", nullable: false, defaultValue: "Pending"),
                    requestType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Create an index for EmployeeId to optimize queries
            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeId",
                table: "LeaveRequests",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the table in case of rollback
            migrationBuilder.DropTable(name: "LeaveRequests");
        }
    }
}
