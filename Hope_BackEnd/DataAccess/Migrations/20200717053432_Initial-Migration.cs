﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diccionarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diccionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(nullable: true),
                    SegundoNombre = table.Column<string>(nullable: true),
                    PrimerApellido = table.Column<string>(nullable: true),
                    SegundoApellido = table.Column<string>(nullable: true),
                    Apodo = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Denuncias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDenunciaPolicia = table.Column<string>(nullable: true),
                    FechaDenuncia = table.Column<DateTime>(nullable: false),
                    FechaDesaparicion = table.Column<DateTime>(nullable: false),
                    HaciaDondeSeDirigiaDireccion = table.Column<string>(nullable: true),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denuncias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Denuncias_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DireccionVivienda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPersona = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionVivienda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DireccionVivienda_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InformacionBasicas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoIdentificacion = table.Column<int>(nullable: false),
                    NumIdentificacion = table.Column<string>(nullable: true),
                    IdNacionalidad = table.Column<int>(nullable: false),
                    IdSexo = table.Column<int>(nullable: false),
                    IdTipoSangre = table.Column<int>(nullable: false),
                    Idioma = table.Column<int>(nullable: false),
                    IdPersona = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionBasicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformacionBasicas_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DireccionDesaparicion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDenuncia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionDesaparicion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DireccionDesaparicion_Denuncias_IdDenuncia",
                        column: x => x.IdDenuncia,
                        principalTable: "Denuncias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InformacionDesaparecidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdColorOjos = table.Column<int>(nullable: false),
                    IdColorPiel = table.Column<int>(nullable: false),
                    IdEstadoCuerpo = table.Column<int>(nullable: false),
                    Altura = table.Column<double>(nullable: false),
                    Peso = table.Column<int>(nullable: false),
                    Apariencia = table.Column<string>(nullable: true),
                    TratoEspecial = table.Column<string>(nullable: true),
                    IdDenuncia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionDesaparecidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformacionDesaparecidos_Denuncias_IdDenuncia",
                        column: x => x.IdDenuncia,
                        principalTable: "Denuncias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InformacionPolicias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRango = table.Column<int>(nullable: false),
                    IdSupervisor = table.Column<int>(nullable: false),
                    IdPersona = table.Column<int>(nullable: false),
                    DenunciaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionPolicias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformacionPolicias_Denuncias_DenunciaId",
                        column: x => x.DenunciaId,
                        principalTable: "Denuncias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InformacionPolicias_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonaDenunciantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoTelefono = table.Column<int>(nullable: false),
                    NumTelefono = table.Column<int>(nullable: false),
                    Confirmado = table.Column<bool>(nullable: false),
                    IdInformacionBasica = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaDenunciantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonaDenunciantes_InformacionBasicas_IdInformacionBasica",
                        column: x => x.IdInformacionBasica,
                        principalTable: "InformacionBasicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Barbas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdColorBarba = table.Column<int>(nullable: false),
                    IdTipoBarba = table.Column<int>(nullable: false),
                    IdLargoBarba = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    IdInformacionDesaparecido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barbas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barbas_InformacionDesaparecidos_IdInformacionDesaparecido",
                        column: x => x.IdInformacionDesaparecido,
                        principalTable: "InformacionDesaparecidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cabellos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdColorCabello = table.Column<int>(nullable: false),
                    IdTipoCabello = table.Column<int>(nullable: false),
                    IdLargoCabello = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    IdInformacionDesaparecido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabellos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cabellos_InformacionDesaparecidos_IdInformacionDesaparecido",
                        column: x => x.IdInformacionDesaparecido,
                        principalTable: "InformacionDesaparecidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discapacidads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoDiscapacidad = table.Column<int>(nullable: false),
                    IdLugarDiscapacidad = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    IdInformacionDesaparecido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discapacidads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discapacidads_InformacionDesaparecidos_IdInformacionDesaparecido",
                        column: x => x.IdInformacionDesaparecido,
                        principalTable: "InformacionDesaparecidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ropas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLugarRopa = table.Column<int>(nullable: false),
                    IdRopa = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    IdInformacionDesaparecido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ropas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ropas_InformacionDesaparecidos_IdInformacionDesaparecido",
                        column: x => x.IdInformacionDesaparecido,
                        principalTable: "InformacionDesaparecidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tatuajes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLugar = table.Column<int>(nullable: false),
                    IdTatuaje = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    IdInformacionDesaparecido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tatuajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tatuajes_InformacionDesaparecidos_IdInformacionDesaparecido",
                        column: x => x.IdInformacionDesaparecido,
                        principalTable: "InformacionDesaparecidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DenunciasPoliciasAsignados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdInformacionPoliciaAsignado = table.Column<int>(nullable: false),
                    InformacionPoliciaId = table.Column<int>(nullable: true),
                    IdDenuncia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DenunciasPoliciasAsignados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DenunciasPoliciasAsignados_Denuncias_IdDenuncia",
                        column: x => x.IdDenuncia,
                        principalTable: "Denuncias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DenunciasPoliciasAsignados_InformacionPolicias_InformacionPoliciaId",
                        column: x => x.InformacionPoliciaId,
                        principalTable: "InformacionPolicias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barbas_IdInformacionDesaparecido",
                table: "Barbas",
                column: "IdInformacionDesaparecido",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cabellos_IdInformacionDesaparecido",
                table: "Cabellos",
                column: "IdInformacionDesaparecido",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Denuncias_PersonaId",
                table: "Denuncias",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_DenunciasPoliciasAsignados_IdDenuncia",
                table: "DenunciasPoliciasAsignados",
                column: "IdDenuncia");

            migrationBuilder.CreateIndex(
                name: "IX_DenunciasPoliciasAsignados_InformacionPoliciaId",
                table: "DenunciasPoliciasAsignados",
                column: "InformacionPoliciaId");

            migrationBuilder.CreateIndex(
                name: "IX_DireccionDesaparicion_IdDenuncia",
                table: "DireccionDesaparicion",
                column: "IdDenuncia");

            migrationBuilder.CreateIndex(
                name: "IX_DireccionVivienda_IdPersona",
                table: "DireccionVivienda",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Discapacidads_IdInformacionDesaparecido",
                table: "Discapacidads",
                column: "IdInformacionDesaparecido",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InformacionBasicas_IdPersona",
                table: "InformacionBasicas",
                column: "IdPersona",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InformacionDesaparecidos_IdDenuncia",
                table: "InformacionDesaparecidos",
                column: "IdDenuncia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InformacionPolicias_DenunciaId",
                table: "InformacionPolicias",
                column: "DenunciaId");

            migrationBuilder.CreateIndex(
                name: "IX_InformacionPolicias_IdPersona",
                table: "InformacionPolicias",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDenunciantes_IdInformacionBasica",
                table: "PersonaDenunciantes",
                column: "IdInformacionBasica");

            migrationBuilder.CreateIndex(
                name: "IX_Ropas_IdInformacionDesaparecido",
                table: "Ropas",
                column: "IdInformacionDesaparecido");

            migrationBuilder.CreateIndex(
                name: "IX_Tatuajes_IdInformacionDesaparecido",
                table: "Tatuajes",
                column: "IdInformacionDesaparecido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barbas");

            migrationBuilder.DropTable(
                name: "Cabellos");

            migrationBuilder.DropTable(
                name: "DenunciasPoliciasAsignados");

            migrationBuilder.DropTable(
                name: "Diccionarios");

            migrationBuilder.DropTable(
                name: "DireccionDesaparicion");

            migrationBuilder.DropTable(
                name: "DireccionVivienda");

            migrationBuilder.DropTable(
                name: "Discapacidads");

            migrationBuilder.DropTable(
                name: "PersonaDenunciantes");

            migrationBuilder.DropTable(
                name: "Ropas");

            migrationBuilder.DropTable(
                name: "Tatuajes");

            migrationBuilder.DropTable(
                name: "InformacionPolicias");

            migrationBuilder.DropTable(
                name: "InformacionBasicas");

            migrationBuilder.DropTable(
                name: "InformacionDesaparecidos");

            migrationBuilder.DropTable(
                name: "Denuncias");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
