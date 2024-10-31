using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutbolBack.Migrations
{
    /// <inheritdoc />
    public partial class ajustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Equipos_EquipoId",
                table: "Entrenadores");

            migrationBuilder.DropIndex(
                name: "IX_Entrenadores_EquipoId",
                table: "Entrenadores");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Entrenadores");

            migrationBuilder.AddColumn<int>(
                name: "EntrenadorId",
                table: "Equipos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntrenadorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntrenadorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 21, 14, 12, 38, 246, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 10, 26, 14, 12, 38, 246, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_EntrenadorId",
                table: "Equipos",
                column: "EntrenadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Entrenadores_EntrenadorId",
                table: "Equipos",
                column: "EntrenadorId",
                principalTable: "Entrenadores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Entrenadores_EntrenadorId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_EntrenadorId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "EntrenadorId",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Entrenadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 1,
                column: "EquipoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 2,
                column: "EquipoId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 19, 21, 11, 40, 159, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 10, 24, 21, 11, 40, 159, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_EquipoId",
                table: "Entrenadores",
                column: "EquipoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Equipos_EquipoId",
                table: "Entrenadores",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
