using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ionic_API.Migrations
{
    /// <inheritdoc />
    public partial class defense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Defense",
                columns: table => new
                {
                    idDefense = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEquipe = table.Column<int>(type: "int", nullable: false),
                    sousType = table.Column<int>(type: "int", nullable: false),
                    tirsPM = table.Column<double>(type: "float", nullable: false),
                    taclesPM = table.Column<double>(type: "float", nullable: false),
                    interceptionsPM = table.Column<double>(type: "float", nullable: false),
                    fautesPM = table.Column<double>(type: "float", nullable: false),
                    horsJeuxPM = table.Column<double>(type: "float", nullable: false),
                    note = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defense", x => x.idDefense);
                    table.ForeignKey(
                        name: "FK_Defense_Equipes_idEquipe",
                        column: x => x.idEquipe,
                        principalTable: "Equipes",
                        principalColumn: "idEquipe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Defense_idEquipe",
                table: "Defense",
                column: "idEquipe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Defense");
        }
    }
}
