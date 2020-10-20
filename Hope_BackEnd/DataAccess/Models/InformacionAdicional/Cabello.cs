using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Barba : Base
    {
        
        public int IdColorBarba { get; set; }
        public int IdTipoBarba { get; set; }
        public int IdLargoBarba { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("InformacionDesaparecido")]
        public int IdInformacionDesaparecido { get; set; }
        public InformacionDesaparecido InformacionDesaparecido { get; set; }
    }
}
