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
    public class PermisoRolRepository : Repository<PermisoRol>, IPermisoRolRepository
    {
        public PermisoRolRepository(HopeContext context) : base(context) { }
    }
}
