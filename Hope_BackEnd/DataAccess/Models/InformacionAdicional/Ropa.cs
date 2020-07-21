using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Ropa
    {
        public int Id { get; set; }
        public int IdLugarRopa { get; set; }
        public int IdRopa { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("InformacionDesaparecido")]
        public int IdInformacionDesaparecido { get; set; }
        public InformacionDesaparecido InformacionDesaparecido { get; set; }
    }
}
