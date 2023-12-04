using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ionic_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    idCompetition = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomCompetition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.idCompetition);
                });

            migrationBuilder.CreateTable(
                name: "Equipes",
                columns: table => new
                {
                    idEquipe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomEquipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idCompetition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipes", x => x.idEquipe);
                    table.ForeignKey(
                        name: "FK_Equipes_Competitions_idCompetition",
                        column: x => x.idCompetition,
                        principalTable: "Competitions",
                        principalColumn: "idCompetition",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "General",
                columns: table => new
                {
                    idGeneral = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEquipe = table.Column<int>(type: "int", nullable: false),
                    sousType = table.Column<int>(type: "int", nullable: false),
                    buts = table.Column<double>(type: "float", nullable: false),
                    tirePM = table.Column<double>(type: "float", nullable: false),
                    jaune = table.Column<double>(type: "float", nullable: false),
                    rouge = table.Column<double>(type: "float", nullable: false),
                    possession = table.Column<double>(type: "float", nullable: false),
                    passesReussies = table.Column<double>(type: "float", nullable: false),
                    aeriensGagnes = table.Column<double>(type: "float", nullable: false),
                    note = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General", x => x.idGeneral);
                    table.ForeignKey(
                        name: "FK_General_Equipes_idEquipe",
                        column: x => x.idEquipe,
                        principalTable: "Equipes",
                        principalColumn: "idEquipe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipes_idCompetition",
                table: "Equipes",
                column: "idCompetition");

            migrationBuilder.CreateIndex(
                name: "IX_General_idEquipe",
                table: "General",
                column: "idEquipe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "General");

            migrationBuilder.DropTable(
                name: "Equipes");

            migrationBuilder.DropTable(
                name: "Competitions");
        }
    }
}
