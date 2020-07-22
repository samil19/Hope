using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddPersonaDenunciante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Denuncias_InformacionDesaparecidos_InformacionAdicionalId",
                table: "Denuncias");

            migrationBuilder.DropForeignKey(
                name: "FK_Denuncias_PersonaDenunciante_PersonaDenuncianteId",
                table: "Denuncias");

            migrationBuilder.DropTable(
                name: "PersonaDenunciante");

            migrationBuilder.DropIndex(
                name: "IX_Denuncias_InformacionAdicionalId",
                table: "Denuncias");

            migrationBuilder.DropColumn(
                name: "Confirmado",
                table: "PersonaDenunciantes");

            migrationBuilder.DropColumn(
                name: "IdTipoTelefono",
                table: "PersonaDenunciantes");

            migrationBuilder.DropColumn(
                name: "NumTelefono",
                table: "PersonaDenunciantes");

            migrationBuilder.DropColumn(
                name: "InformacionAdicionalId",
                table: "Denuncias");

            migrationBuilder.AddColumn<int>(
                name: "IdParentesco",
                table: "PersonaDenunciantes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InformacionDesaparecidoId",
                table: "Denuncias",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Telefono",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoTelefono = table.Column<int>(nullable: false),
                    NumTelefono = table.Column<int>(nullable: false),
                    Confirmado = table.Column<bool>(nullable: false),
                    InformacionBasicaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefono", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefono_InformacionBasicas_InformacionBasicaId",
                        column: x => x.InformacionBasicaId,
                        principalTable: "InformacionBasicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Denuncias_InformacionDesaparecidoId",
                table: "Denuncias",
                column: "InformacionDesaparecidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefono_InformacionBasicaId",
                table: "Telefono",
                column: "InformacionBasicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Denuncias_InformacionDesaparecidos_InformacionDesaparecidoId",
                table: "Denuncias",
                column: "InformacionDesaparecidoId",
                principalTable: "InformacionDesaparecidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Denuncias_PersonaDenunciantes_PersonaDenuncianteId",
                table: "Denuncias",
                column: "PersonaDenuncianteId",
                principalTable: "PersonaDenunciantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Denuncias_InformacionDesaparecidos_InformacionDesaparecidoId",
                table: "Denuncias");

            migrationBuilder.DropForeignKey(
                name: "FK_Denuncias_PersonaDenunciantes_PersonaDenuncianteId",
                table: "Denuncias");

            migrationBuilder.DropTable(
                name: "Telefono");

            migrationBuilder.DropIndex(
                name: "IX_Denuncias_InformacionDesaparecidoId",
                table: "Denuncias");

            migrationBuilder.DropColumn(
                name: "IdParentesco",
                table: "PersonaDenunciantes");

            migrationBuilder.DropColumn(
                name: "InformacionDesaparecidoId",
                table: "Denuncias");

            migrationBuilder.AddColumn<bool>(
                name: "Confirmado",
                table: "PersonaDenunciantes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoTelefono",
                table: "PersonaDenunciantes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumTelefono",
                table: "PersonaDenunciantes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InformacionAdicionalId",
                table: "Denuncias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersonaDenunciante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdParentesco = table.Column<int>(type: "int", nullable: false),
                    InformacionBasicaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaDenunciante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonaDenunciante_InformacionBasicas_InformacionBasicaId",
                        column: x => x.InformacionBasicaId,
                        principalTable: "InformacionBasicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Denuncias_InformacionAdicionalId",
                table: "Denuncias",
                column: "InformacionAdicionalId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDenunciante_InformacionBasicaId",
                table: "PersonaDenunciante",
                column: "InformacionBasicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Denuncias_InformacionDesaparecidos_InformacionAdicionalId",
                table: "Denuncias",
                column: "InformacionAdicionalId",
                principalTable: "InformacionDesaparecidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Denuncias_PersonaDenunciante_PersonaDenuncianteId",
                table: "Denuncias",
                column: "PersonaDenuncianteId",
                principalTable: "PersonaDenunciante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
