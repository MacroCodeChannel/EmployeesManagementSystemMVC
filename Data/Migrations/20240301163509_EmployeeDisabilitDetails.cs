using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeDisabilitDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisabilityCertificate",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisabilityId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PaysTax",
                table: "Employees",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DisabilityId",
                table: "Employees",
                column: "DisabilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_SystemCodeDetails_DisabilityId",
                table: "Employees",
                column: "DisabilityId",
                principalTable: "SystemCodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_SystemCodeDetails_DisabilityId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DisabilityId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DisabilityCertificate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DisabilityId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PaysTax",
                table: "Employees");
        }
    }
}
