using DataAccess.EntityFramework;
using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class RopaRepository : Repository<Ropa>, IRopaRepository
    {
        public RopaRepository(HopeContext context) : base(context) { }
    }
}
