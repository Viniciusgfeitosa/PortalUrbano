using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_urbano.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordResetToUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gostei_denuncias_DenunciaId",
                table: "gostei");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_denuncias_TempId",
                table: "denuncias");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "denuncias");

            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordResetExpires",
                table: "usuarios",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordResetToken",
                table: "usuarios",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_gostei_denuncias_DenunciaId",
                table: "gostei",
                column: "DenunciaId",
                principalTable: "denuncias",
                principalColumn: "IdDenuncia",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gostei_denuncias_DenunciaId",
                table: "gostei");

            migrationBuilder.DropColumn(
                name: "PasswordResetExpires",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "PasswordResetToken",
                table: "usuarios");

            migrationBuilder.AddColumn<long>(
                name: "TempId",
                table: "denuncias",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_denuncias_TempId",
                table: "denuncias",
                column: "TempId");

            migrationBuilder.AddForeignKey(
                name: "FK_gostei_denuncias_DenunciaId",
                table: "gostei",
                column: "DenunciaId",
                principalTable: "denuncias",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
