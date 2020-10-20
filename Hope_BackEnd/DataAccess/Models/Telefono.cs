using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Telefono : Base
    {
        
        public int IdTipoTelefono { get; set; }
        public int NumTelefono { get; set; }
        public bool Confirmado { get; set; }
        //Agregar a la persona del telefono?
        public InformacionBasica InformacionBasica { get; set; }
    }
}
