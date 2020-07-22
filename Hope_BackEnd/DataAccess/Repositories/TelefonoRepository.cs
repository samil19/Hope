using DataAccess.EntityFramework;
using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class TelefonoRepository : Repository<Telefono>, ITelefonoRepository
    {
        public TelefonoRepository(HopeContext context) : base(context) { }
    }
}
