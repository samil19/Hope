﻿// <auto-generated />
using System;
using DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(HopeContext))]
    partial class HopeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Models.Account.Permiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("DataAccess.Models.Account.PermisoRol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermisoId")
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PermisoId");

                    b.HasIndex("RolId");

                    b.ToTable("PermisosRoles");
                });

            modelBuilder.Entity("DataAccess.Models.Account.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DataAccess.Models.Account.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IpRegistro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PersonaId");

                    b.HasIndex("RolId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DataAccess.Models.Barba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdColorBarba")
                        .HasColumnType("int");

                    b.Property<int>("IdInformacionDesaparecido")
                        .HasColumnType("int");

                    b.Property<int>("IdLargoBarba")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoBarba")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdInformacionDesaparecido")
                        .IsUnique();

                    b.ToTable("Barbas");
                });

            modelBuilder.Entity("DataAccess.Models.Cabello", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdColorCabello")
                        .HasColumnType("int");

                    b.Property<int>("IdInformacionDesaparecido")
                        .HasColumnType("int");

                    b.Property<int>("IdLargoCabello")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoCabello")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdInformacionDesaparecido")
                        .IsUnique();

                    b.ToTable("Cabellos");
                });

            modelBuilder.Entity("DataAccess.Models.Denuncia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaDenuncia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDesaparicion")
                        .HasColumnType("datetime2");

                    b.Property<string>("HaciaDondeSeDirigiaDireccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InformacionDesaparecidoId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroDenunciaPolicia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaDenuncianteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InformacionDesaparecidoId");

                    b.HasIndex("PersonaDenuncianteId");

                    b.ToTable("Denuncias");
                });

            modelBuilder.Entity("DataAccess.Models.DenunciasPoliciasAsignado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DenunciaId")
                        .HasColumnType("int");

                    b.Property<int?>("InformacionPoliciaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DenunciaId");

                    b.HasIndex("InformacionPoliciaId");

                    b.ToTable("DenunciasPoliciasAsignados");
                });

            modelBuilder.Entity("DataAccess.Models.Diccionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPadre")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Diccionarios");
                });

            modelBuilder.Entity("DataAccess.Models.Direcciones.DireccionDesaparicion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdDenuncia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDenuncia");

                    b.ToTable("DireccionDesaparicion");
                });

            modelBuilder.Entity("DataAccess.Models.Direcciones.DireccionVivienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("DireccionVivienda");
                });

            modelBuilder.Entity("DataAccess.Models.Discapacidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdInformacionDesaparecido")
                        .HasColumnType("int");

                    b.Property<int>("IdLugarDiscapacidad")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDiscapacidad")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdInformacionDesaparecido")
                        .IsUnique();

                    b.ToTable("Discapacidads");
                });

            modelBuilder.Entity("DataAccess.Models.InformacionBasica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdNacionalidad")
                        .HasColumnType("int");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoIdentificacion")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoSangre")
                        .HasColumnType("int");

                    b.Property<int>("Idioma")
                        .HasColumnType("int");

                    b.Property<string>("NumIdentificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("InformacionBasicas");
                });

            modelBuilder.Entity("DataAccess.Models.InformacionDesaparecido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<string>("Apariencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdColorOjos")
                        .HasColumnType("int");

                    b.Property<int>("IdColorPiel")
                        .HasColumnType("int");

                    b.Property<int>("IdDenuncia")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoCuerpo")
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<string>("TratoEspecial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdPersona");

                    b.ToTable("InformacionDesaparecidos");
                });

            modelBuilder.Entity("DataAccess.Models.InformacionPolicia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdRango")
                        .HasColumnType("int");

                    b.Property<int>("IdSupervisor")
                        .HasColumnType("int");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("InformacionPolicias");
                });

            modelBuilder.Entity("DataAccess.Models.Logging.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ElementId")
                        .HasColumnType("int");

                    b.Property<string>("ElementTable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("LogInId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LogInId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("DataAccess.Models.Logging.LogIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaLogIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaLogOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogInType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SessionTime")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("LogIns");
                });

            modelBuilder.Entity("DataAccess.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apodo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("DataAccess.Models.PersonaDenunciante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdParentesco")
                        .HasColumnType("int");

                    b.Property<int?>("InformacionBasicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InformacionBasicaId");

                    b.ToTable("PersonaDenunciantes");
                });

            modelBuilder.Entity("DataAccess.Models.Ropa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdInformacionDesaparecido")
                        .HasColumnType("int");

                    b.Property<int>("IdLugarRopa")
                        .HasColumnType("int");

                    b.Property<int>("IdRopa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdInformacionDesaparecido");

                    b.ToTable("Ropas");
                });

            modelBuilder.Entity("DataAccess.Models.Tatuaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdInformacionDesaparecido")
                        .HasColumnType("int");

                    b.Property<int>("IdLugar")
                        .HasColumnType("int");

                    b.Property<int>("IdTatuaje")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdInformacionDesaparecido");

                    b.ToTable("Tatuajes");
                });

            modelBuilder.Entity("DataAccess.Models.Telefono", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Confirmado")
                        .HasColumnType("bit");

                    b.Property<int>("IdTipoTelefono")
                        .HasColumnType("int");

                    b.Property<int?>("InformacionBasicaId")
                        .HasColumnType("int");

                    b.Property<int>("NumTelefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InformacionBasicaId");

                    b.ToTable("Telefono");
                });

            modelBuilder.Entity("DataAccess.Models.Account.PermisoRol", b =>
                {
                    b.HasOne("DataAccess.Models.Account.Permiso", "Permiso")
                        .WithMany()
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Account.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Account.User", b =>
                {
                    b.HasOne("DataAccess.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Account.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Barba", b =>
                {
                    b.HasOne("DataAccess.Models.InformacionDesaparecido", "InformacionDesaparecido")
                        .WithOne("Barba")
                        .HasForeignKey("DataAccess.Models.Barba", "IdInformacionDesaparecido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Cabello", b =>
                {
                    b.HasOne("DataAccess.Models.InformacionDesaparecido", "InformacionDesaparecido")
                        .WithOne("Cabello")
                        .HasForeignKey("DataAccess.Models.Cabello", "IdInformacionDesaparecido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Denuncia", b =>
                {
                    b.HasOne("DataAccess.Models.InformacionDesaparecido", "InformacionDesaparecido")
                        .WithMany("Denuncias")
                        .HasForeignKey("InformacionDesaparecidoId");

                    b.HasOne("DataAccess.Models.PersonaDenunciante", "PersonaDenunciante")
                        .WithMany()
                        .HasForeignKey("PersonaDenuncianteId");
                });

            modelBuilder.Entity("DataAccess.Models.DenunciasPoliciasAsignado", b =>
                {
                    b.HasOne("DataAccess.Models.Denuncia", "Denuncia")
                        .WithMany("PoliciasAsignados")
                        .HasForeignKey("DenunciaId");

                    b.HasOne("DataAccess.Models.InformacionPolicia", "InformacionPolicia")
                        .WithMany()
                        .HasForeignKey("InformacionPoliciaId");
                });

            modelBuilder.Entity("DataAccess.Models.Direcciones.DireccionDesaparicion", b =>
                {
                    b.HasOne("DataAccess.Models.Denuncia", "Denuncia")
                        .WithMany("LugarVisto")
                        .HasForeignKey("IdDenuncia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Direcciones.DireccionVivienda", b =>
                {
                    b.HasOne("DataAccess.Models.Persona", "Persona")
                        .WithMany("DireccionVivienda")
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("DataAccess.Models.Discapacidad", b =>
                {
                    b.HasOne("DataAccess.Models.InformacionDesaparecido", "InformacionDesaparecido")
                        .WithOne("Discapacidad")
                        .HasForeignKey("DataAccess.Models.Discapacidad", "IdInformacionDesaparecido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.InformacionBasica", b =>
                {
                    b.HasOne("DataAccess.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("DataAccess.Models.InformacionDesaparecido", b =>
                {
                    b.HasOne("DataAccess.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("IdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.InformacionPolicia", b =>
                {
                    b.HasOne("DataAccess.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("DataAccess.Models.Logging.Log", b =>
                {
                    b.HasOne("DataAccess.Models.Logging.LogIn", "LogIn")
                        .WithMany()
                        .HasForeignKey("LogInId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Logging.LogIn", b =>
                {
                    b.HasOne("DataAccess.Models.Account.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.PersonaDenunciante", b =>
                {
                    b.HasOne("DataAccess.Models.InformacionBasica", "InformacionBasica")
                        .WithMany()
                        .HasForeignKey("InformacionBasicaId");
                });

            modelBuilder.Entity("DataAccess.Models.Ropa", b =>
                {
                    b.HasOne("DataAccess.Models.InformacionDesaparecido", "InformacionDesaparecido")
                        .WithMany("Ropas")
                        .HasForeignKey("IdInformacionDesaparecido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Tatuaje", b =>
                {
                    b.HasOne("DataAccess.Models.InformacionDesaparecido", "InformacionDesaparecido")
                        .WithMany("Tatuajes")
                        .HasForeignKey("IdInformacionDesaparecido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Telefono", b =>
                {
                    b.HasOne("DataAccess.Models.InformacionBasica", "InformacionBasica")
                        .WithMany("Telefonos")
                        .HasForeignKey("InformacionBasicaId");
                });
#pragma warning restore 612, 618
        }
    }
}
