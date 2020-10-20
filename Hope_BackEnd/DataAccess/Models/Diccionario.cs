using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Diccionario : Base
    {
        
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int IdPadre { get; set; }
    }
}
