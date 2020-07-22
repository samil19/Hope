using DataAccess.EntityFramework;
using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class InformacionBasicaRepository : Repository<InformacionBasica>, IInformacionBasicaRepository
    {
        public InformacionBasicaRepository(HopeContext context) : base(context) { }
    }
}
