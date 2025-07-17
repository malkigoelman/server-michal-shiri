using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smr.Data.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "renters",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryNameOfBusiness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    Userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_renters", x => x.id);
                    table.ForeignKey(
                        name: "FK_renters_users_Userid",
                        column: x => x.Userid,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tourists",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryNameOfBusiness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tourists", x => x.id);
                    table.ForeignKey(
                        name: "FK_tourists_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "turns",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TouristId = table.Column<int>(type: "int", nullable: false),
                    Renterid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turns", x => x.id);
                    table.ForeignKey(
                        name: "FK_turns_renters_Renterid",
                        column: x => x.Renterid,
                        principalTable: "renters",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_turns_tourists_TouristId",
                        column: x => x.TouristId,
                        principalTable: "tourists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_renters_Userid",
                table: "renters",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_tourists_UserId",
                table: "tourists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_turns_Renterid",
                table: "turns",
                column: "Renterid");

            migrationBuilder.CreateIndex(
                name: "IX_turns_TouristId",
                table: "turns",
                column: "TouristId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "turns");

            migrationBuilder.DropTable(
                name: "renters");

            migrationBuilder.DropTable(
                name: "tourists");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
