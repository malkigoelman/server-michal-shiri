using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smr.Data.Migrations
{
    public partial class updateUserss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tourists_users_UserRoleId",
                table: "tourists");

            migrationBuilder.DropIndex(
                name: "IX_tourists_UserRoleId",
                table: "tourists");

            migrationBuilder.DropColumn(
                name: "UserRoleId",
                table: "tourists");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "renters");

            migrationBuilder.AddColumn<string>(
                name: "Userid",
                table: "tourists",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Userid",
                table: "renters",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_tourists_Userid",
                table: "tourists",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_renters_Userid",
                table: "renters",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_renters_users_Userid",
                table: "renters",
                column: "Userid",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tourists_users_Userid",
                table: "tourists",
                column: "Userid",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_renters_users_Userid",
                table: "renters");

            migrationBuilder.DropForeignKey(
                name: "FK_tourists_users_Userid",
                table: "tourists");

            migrationBuilder.DropIndex(
                name: "IX_tourists_Userid",
                table: "tourists");

            migrationBuilder.DropIndex(
                name: "IX_renters_Userid",
                table: "renters");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "tourists");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "renters");

            migrationBuilder.AddColumn<string>(
                name: "UserRoleId",
                table: "tourists",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "renters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tourists_UserRoleId",
                table: "tourists",
                column: "UserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_tourists_users_UserRoleId",
                table: "tourists",
                column: "UserRoleId",
                principalTable: "users",
                principalColumn: "Id");
        }
    }
}
