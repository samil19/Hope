﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class InformacionBasica
    {
        public int Id { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public string NumIdentificacion { get; set; }
        public int IdNacionalidad { get; set; }
        public int IdSexo { get; set; }
        public int IdTipoSangre { get; set; }
        public int Idioma { get; set; }
        public ICollection<Telefono> Telefonos { get; set; }
        [ForeignKey("Persona")]
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }

    }
}