using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smr.Data.Migrations
{
    public partial class migrats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "renters",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryNameOfBusiness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_renters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tourists",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    phonNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tourists", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "turns",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hour = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turns", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "renters");

            migrationBuilder.DropTable(
                name: "tourists");

            migrationBuilder.DropTable(
                name: "turns");
        }
    }
}
