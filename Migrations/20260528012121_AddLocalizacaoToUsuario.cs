using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_urbano.Migrations
{
    /// <inheritdoc />
    public partial class AddLocalizacaoToUsuario : Migration
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
                name: "Telefone",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "denuncias");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordResetToken",
                table: "usuarios",
                type: "varchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Uf",
                table: "usuarios",
                type: "varchar(2)",
                maxLength: 2,
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
                name: "Bairro",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "Uf",
                table: "usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordResetToken",
                table: "usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "usuarios",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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
