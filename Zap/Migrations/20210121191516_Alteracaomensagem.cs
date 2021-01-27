using Microsoft.EntityFrameworkCore.Migrations;

namespace Zap.Migrations
{
    public partial class Alteracaomensagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "Mensagens",
                newName: "UsuarioJson");

            migrationBuilder.RenameColumn(
                name: "DataCricao",
                table: "Mensagens",
                newName: "DataCriacao");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Mensagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Mensagens");

            migrationBuilder.RenameColumn(
                name: "UsuarioJson",
                table: "Mensagens",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Mensagens",
                newName: "DataCricao");
        }
    }
}
