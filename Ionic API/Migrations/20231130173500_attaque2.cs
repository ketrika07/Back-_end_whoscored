using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ionic_API.Migrations
{
    /// <inheritdoc />
    public partial class attaque2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attaques_Equipes_idEquipe",
                table: "Attaques");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attaques",
                table: "Attaques");

            migrationBuilder.RenameTable(
                name: "Attaques",
                newName: "Attaque");

            migrationBuilder.RenameIndex(
                name: "IX_Attaques_idEquipe",
                table: "Attaque",
                newName: "IX_Attaque_idEquipe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attaque",
                table: "Attaque",
                column: "idAttaque");

            migrationBuilder.AddForeignKey(
                name: "FK_Attaque_Equipes_idEquipe",
                table: "Attaque",
                column: "idEquipe",
                principalTable: "Equipes",
                principalColumn: "idEquipe",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attaque_Equipes_idEquipe",
                table: "Attaque");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attaque",
                table: "Attaque");

            migrationBuilder.RenameTable(
                name: "Attaque",
                newName: "Attaques");

            migrationBuilder.RenameIndex(
                name: "IX_Attaque_idEquipe",
                table: "Attaques",
                newName: "IX_Attaques_idEquipe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attaques",
                table: "Attaques",
                column: "idAttaque");

            migrationBuilder.AddForeignKey(
                name: "FK_Attaques_Equipes_idEquipe",
                table: "Attaques",
                column: "idEquipe",
                principalTable: "Equipes",
                principalColumn: "idEquipe",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
