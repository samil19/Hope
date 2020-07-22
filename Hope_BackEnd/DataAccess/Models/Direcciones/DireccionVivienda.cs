using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models.Direcciones
{
    public class DireccionVivienda
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
    }
}
