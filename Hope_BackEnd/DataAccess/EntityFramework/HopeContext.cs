using DataAccess.Models;
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
        public DbSet<Telefono> PersonaDenunciantes { get; set; }
        public DbSet<Ropa> Ropas { get; set; }
        public DbSet<Cabello> Cabellos { get; set; }
        public DbSet<Barba> Barbas { get; set; }
        public DbSet<Discapacidad> Discapacidads { get; set; }
        public DbSet<Tatuaje> Tatuajes { get; set; }
        public DbSet<DenunciasPoliciasAsignado> DenunciasPoliciasAsignados { get; set; }
    }
}
