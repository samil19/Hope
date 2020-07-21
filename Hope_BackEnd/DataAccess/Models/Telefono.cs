using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Telefono
    {
        public int Id { get; set; }
        public int IdTipoTelefono { get; set; }
        public int NumTelefono { get; set; }
        public bool Confirmado { get; set; }
        //Agregar a la persona del telefono?
        [ForeignKey("InformacionBasica")]
        public int IdInformacionBasica { get; set; }
        public InformacionBasica InformacionBasica { get; set; }
    }
}
