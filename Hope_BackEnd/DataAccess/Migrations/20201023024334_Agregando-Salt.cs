using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AgregandoSalt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "Usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Usuarios");
        }
    }
}
