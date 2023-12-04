using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ionic_API.Migrations
{
    /// <inheritdoc />
    public partial class general : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipes_Competitions_idCompetition",
                table: "Equipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competitions",
                table: "Competitions");

            migrationBuilder.RenameTable(
                name: "Competitions",
                newName: "Competition");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competition",
                table: "Competition",
                column: "idCompetition");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipes_Competition_idCompetition",
                table: "Equipes",
                column: "idCompetition",
                principalTable: "Competition",
                principalColumn: "idCompetition",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipes_Competition_idCompetition",
                table: "Equipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competition",
                table: "Competition");

            migrationBuilder.RenameTable(
                name: "Competition",
                newName: "Competitions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competitions",
                table: "Competitions",
                column: "idCompetition");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipes_Competitions_idCompetition",
                table: "Equipes",
                column: "idCompetition",
                principalTable: "Competitions",
                principalColumn: "idCompetition",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
