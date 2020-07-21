using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Cabello
    {
        public int Id { get; set; }
        public int IdColorCabello { get; set; }
        public int IdTipoCabello { get; set; }
        public int IdLargoCabello { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("InformacionDesaparecido")]
        public int IdInformacionDesaparecido { get; set; }
        public InformacionDesaparecido InformacionDesaparecido { get; set; }
    }
}
