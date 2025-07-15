using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smr.Data.Migrations
{
    public partial class conect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phonNumber",
                table: "tourists",
                newName: "CountryNameOfBusiness");

            migrationBuilder.AddColumn<string>(
                name: "Renterid",
                table: "turns",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TouristId",
                table: "turns",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_turns_Renterid",
                table: "turns",
                column: "Renterid");

            migrationBuilder.CreateIndex(
                name: "IX_turns_TouristId",
                table: "turns",
                column: "TouristId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_turns_renters_Renterid",
                table: "turns",
                column: "Renterid",
                principalTable: "renters",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_turns_tourists_TouristId",
                table: "turns",
                column: "TouristId",
                principalTable: "tourists",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turns_renters_Renterid",
                table: "turns");

            migrationBuilder.DropForeignKey(
                name: "FK_turns_tourists_TouristId",
                table: "turns");

            migrationBuilder.DropIndex(
                name: "IX_turns_Renterid",
                table: "turns");

            migrationBuilder.DropIndex(
                name: "IX_turns_TouristId",
                table: "turns");

            migrationBuilder.DropColumn(
                name: "Renterid",
                table: "turns");

            migrationBuilder.DropColumn(
                name: "TouristId",
                table: "turns");

            migrationBuilder.RenameColumn(
                name: "CountryNameOfBusiness",
                table: "tourists",
                newName: "phonNumber");
        }
    }
}
