using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AgregandoIpRegistro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IpRegistro",
                table: "Usuarios",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IpRegistro",
                table: "Usuarios");
        }
    }
}
