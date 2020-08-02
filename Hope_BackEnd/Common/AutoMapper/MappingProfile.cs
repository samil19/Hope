using AutoMapper;
using Common.DTOs;
using DataAccess.Models;
using DataAccess.Models.Direcciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Persona, PersonaDto>();
            CreateMap<PersonaDto, Persona>();
            CreateMap<DireccionVivienda, DireccionViviendaDto>();
            CreateMap<DireccionViviendaDto, DireccionVivienda>();
        }
    }
}
