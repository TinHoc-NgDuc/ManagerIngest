using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagerIngest.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userName",
                table: "UserLogin",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "UserLogin",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "userLoginId",
                table: "UserLogin",
                newName: "UserLoginId");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "UserLogin",
                newName: "userName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "UserLogin",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "UserLoginId",
                table: "UserLogin",
                newName: "userLoginId");
        }
    }
}
