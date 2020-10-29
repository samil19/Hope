using DataAccess.Models;
using DataAccess.Models.Account;
using DataAccess.Models.Logging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class HopeContext : DbContext
    {
        public HopeContext(DbContextOptions<HopeContext> options) : base(options)
        {
        }
        public DbSet<Denuncia> Denuncias { get; set; }
        public DbSet<Diccionario> Diccionarios { get; set; }
        public DbSet<InformacionBasica> InformacionBasicas { get; set; }
        public DbSet<InformacionDesaparecido> InformacionDesaparecidos { get; set; }
        public DbSet<InformacionPolicia> InformacionPolicias { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<PersonaDenunciante> PersonaDenunciantes { get; set; }
        public DbSet<Telefono> Telefono { get; set; }
        public DbSet<Ropa> Ropas { get; set; }
        public DbSet<Cabello> Cabellos { get; set; }
        public DbSet<Barba> Barbas { get; set; }
        public DbSet<Discapacidad> Discapacidads { get; set; }
        public DbSet<Tatuaje> Tatuajes { get; set; }
        public DbSet<DenunciasPoliciasAsignado> DenunciasPoliciasAsignados { get; set; }
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<LogIn> LogIns { get; set; }
        public DbSet<PermisoRol> PermisosRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            builder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();
        }
    }
}
