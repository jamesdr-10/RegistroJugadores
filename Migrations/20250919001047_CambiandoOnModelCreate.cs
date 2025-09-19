using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroJugadores.Migrations
{
    /// <inheritdoc />
    public partial class CambiandoOnModelCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Jugadores_JugadorId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Partidas_PartidaId",
                table: "Movimientos");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Jugadores_JugadorId",
                table: "Movimientos",
                column: "JugadorId",
                principalTable: "Jugadores",
                principalColumn: "JugadorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Partidas_PartidaId",
                table: "Movimientos",
                column: "PartidaId",
                principalTable: "Partidas",
                principalColumn: "PartidaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Jugadores_JugadorId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Partidas_PartidaId",
                table: "Movimientos");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Jugadores_JugadorId",
                table: "Movimientos",
                column: "JugadorId",
                principalTable: "Jugadores",
                principalColumn: "JugadorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Partidas_PartidaId",
                table: "Movimientos",
                column: "PartidaId",
                principalTable: "Partidas",
                principalColumn: "PartidaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
