using Common.DTOs;
using DataAccess;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Personas
{
    public class PersonasLogic
    {
        public readonly HopeContext _context;
        public readonly UnitOfWork unitOfWork;
        public PersonasLogic(HopeContext context)
        {
            _context = context;
            unitOfWork = new UnitOfWork(_context);
        }
        public int Insert(PersonaDto data)
        {
            unitOfWork.Persona.Insert(data);
            return 
        }
    }
}
