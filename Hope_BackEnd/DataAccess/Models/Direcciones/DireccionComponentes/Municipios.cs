using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models.DireccionComponentes
{
    public class Municipios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdProvincia { get; set; }
    }
}
