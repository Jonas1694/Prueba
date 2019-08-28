using Microsoft.EntityFrameworkCore.Migrations;

namespace ArquitecturaModel.Migrations
{
    public partial class AjustesModelos1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Proveedores",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Proveedores",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
