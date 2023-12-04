using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ionic_API.Migrations
{
    /// <inheritdoc />
    public partial class attaque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attaques",
                columns: table => new
                {
                    idAttaque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEquipe = table.Column<int>(type: "int", nullable: false),
                    sousType = table.Column<int>(type: "int", nullable: false),
                    tirsPM = table.Column<double>(type: "float", nullable: false),
                    tirsCApm = table.Column<double>(type: "float", nullable: false),
                    dribblesPM = table.Column<double>(type: "float", nullable: false),
                    fautesSubiesPM = table.Column<double>(type: "float", nullable: false),
                    note = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attaques", x => x.idAttaque);
                    table.ForeignKey(
                        name: "FK_Attaques_Equipes_idEquipe",
                        column: x => x.idEquipe,
                        principalTable: "Equipes",
                        principalColumn: "idEquipe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attaques_idEquipe",
                table: "Attaques",
                column: "idEquipe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attaques");
        }
    }
}
