using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KeklandBankSystem.Migrations
{
    public partial class rolePermissionReduce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "PermissionAdmins");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "PermissionAdmins",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "PermissionAdmins");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "PermissionAdmins",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
