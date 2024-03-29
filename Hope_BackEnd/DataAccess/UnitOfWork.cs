﻿using DataAccess.EntityFramework;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HopeContext _context;
        public IBarbaRepository Barba { get; private set; }
        public ICabelloRepository Cabello { get; private set; }
        public IDenunciaRepository Denuncia { get; private set; }
        public IDiccionarioRepository Diccionario { get; private set; }
        public IDiscapacidadRepository Discapacidad { get; private set; }
        public IInformacionBasicaRepository InformacionBasica { get; private set; }
        public IInformacionPoliciaRepository InformacionPolicia { get; private set; }
        public IPersonaDenuncianteRepository PersonaDenunciante { get; private set; }
        public IPersonaRepository Persona { get; private set; }
        public IRopaRepository Ropa { get; private set; }
        public ITatuajeRepository Tatuaje { get; private set; }
        public ITelefonoRepository Telefono { get; private set; }
        public IUserRepository Usuario { get; private set; }
        public IPermisoRepository Permiso { get; private set; }
        public IPermisoRolRepository PermisoRol { get; private set; }
        public IRolRepository Rol { get; private set; }
        public UnitOfWork(HopeContext context)
        {
            _context = context;
            Barba = new BarbaRepository(_context);
        Cabello = new CabelloRepository(_context);
        Denuncia = new DenunciaRepository(_context);
        Diccionario = new DiccionarioRepository(_context);
        Discapacidad = new DiscapacidadRepository(_context);
        InformacionBasica = new InformacionBasicaRepository(_context);
        InformacionPolicia = new InformacionPoliciaRepository(_context);
        PersonaDenunciante = new PersonaDenuncianteRepository(_context);
        Persona = new PersonaRepository(_context);
        Ropa = new RopaRepository(_context);
        Tatuaje = new TatuajeRepository(_context);
        Telefono = new TelefonoRepository(_context);
        Usuario = new UserRepository(_context);
        Rol = new RolRepository(_context);
            Permiso = new PermisoRepository(_context);
            PermisoRol = new PermisoRolRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
