using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class WorkflowUserGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkFlowUserGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowUserGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlowUserGroupMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkFlowUserGroupId = table.Column<int>(type: "int", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApproverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SequenceNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowUserGroupMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlowUserGroupMembers_AspNetUsers_ApproverId",
                        column: x => x.ApproverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkFlowUserGroupMembers_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkFlowUserGroupMembers_WorkFlowUserGroups_WorkFlowUserGroupId",
                        column: x => x.WorkFlowUserGroupId,
                        principalTable: "WorkFlowUserGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowUserGroupMembers_ApproverId",
                table: "WorkFlowUserGroupMembers",
                column: "ApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowUserGroupMembers_SenderId",
                table: "WorkFlowUserGroupMembers",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowUserGroupMembers_WorkFlowUserGroupId",
                table: "WorkFlowUserGroupMembers",
                column: "WorkFlowUserGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkFlowUserGroupMembers");

            migrationBuilder.DropTable(
                name: "WorkFlowUserGroups");
        }
    }
}
