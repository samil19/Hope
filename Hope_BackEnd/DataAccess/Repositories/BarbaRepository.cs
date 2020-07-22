using DataAccess.EntityFramework;
using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class BarbaRepository : Repository<Barba>, IBarbaRepository
    {
        public BarbaRepository(HopeContext context) : base(context) { }
    }
}
