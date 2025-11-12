using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academico.Migrations
{
    /// <inheritdoc />
    public partial class departamentoOrigem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituicao_InstituicaoOrigemInstituicaoId",
                table: "Departamentos");

            migrationBuilder.RenameColumn(
                name: "InstituicaoOrigemInstituicaoId",
                table: "Departamentos",
                newName: "InstituicaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Departamentos_InstituicaoOrigemInstituicaoId",
                table: "Departamentos",
                newName: "IX_Departamentos_InstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituicao_InstituicaoId",
                table: "Departamentos",
                column: "InstituicaoId",
                principalTable: "Instituicao",
                principalColumn: "InstituicaoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Instituicao_InstituicaoId",
                table: "Departamentos");

            migrationBuilder.RenameColumn(
                name: "InstituicaoId",
                table: "Departamentos",
                newName: "InstituicaoOrigemInstituicaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Departamentos_InstituicaoId",
                table: "Departamentos",
                newName: "IX_Departamentos_InstituicaoOrigemInstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Instituicao_InstituicaoOrigemInstituicaoId",
                table: "Departamentos",
                column: "InstituicaoOrigemInstituicaoId",
                principalTable: "Instituicao",
                principalColumn: "InstituicaoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
