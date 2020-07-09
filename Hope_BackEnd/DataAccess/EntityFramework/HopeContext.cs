using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class HopeContext : DbContext
    {
        public HopeContext(DbContextOptions options) : base(options)
        {

        }
    }
}
