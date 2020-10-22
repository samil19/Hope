using AutoMapper;
using Common.DTOs;
using DataAccess;
using DataAccess.EntityFramework;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Personas
{
    public class PersonasLogic
    {
        public readonly HopeContext _context;
        public readonly UnitOfWork unitOfWork;
        public readonly IMapper _mapper;
        public PersonasLogic(HopeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            unitOfWork = new UnitOfWork(_context);
        }
        public void Insert(PersonaDto data)
        {
            Persona PersonaToDb = _mapper.Map<Persona>(data);
            //unitOfWork.Persona.Insert(PersonaToDb);
            unitOfWork.Complete();

        }
        public void InsertPersonWithoutLog(PersonaDto data)
        {
            Persona PersonaToDb = _mapper.Map<Persona>(data);
            unitOfWork.Persona.InsertWithoutLog(PersonaToDb);
        }
    }
}
