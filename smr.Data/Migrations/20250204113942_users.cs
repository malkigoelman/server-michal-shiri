using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smr.Data.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_turns_TouristId",
                table: "turns");

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

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_turns_TouristId",
                table: "turns",
                column: "TouristId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tourists_users_UserRoleId",
                table: "tourists");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropIndex(
                name: "IX_turns_TouristId",
                table: "turns");

            migrationBuilder.DropIndex(
                name: "IX_tourists_UserRoleId",
                table: "tourists");

            migrationBuilder.DropColumn(
                name: "UserRoleId",
                table: "tourists");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "renters");

            migrationBuilder.CreateIndex(
                name: "IX_turns_TouristId",
                table: "turns",
                column: "TouristId",
                unique: true);
        }
    }
}
