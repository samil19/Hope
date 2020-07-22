using DataAccess.EntityFramework;
using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class DiccionarioRepository : Repository<Diccionario>, IDiccionarioRepository
    {
        public DiccionarioRepository(HopeContext context) : base(context) { }
    }
}
