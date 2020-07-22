using DataAccess.EntityFramework;
using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class TatuajeRepository : Repository<Tatuaje>, ITatuajeRepository
    {
        public TatuajeRepository(HopeContext context) : base(context) { }
    }
}
