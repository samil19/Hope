using DataAccess.EntityFramework;
using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Models.Account;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class PermisoRepository : Repository<Permiso>, IPermisoRepository
    {
        public PermisoRepository(HopeContext context) : base(context) { }
    }
}
