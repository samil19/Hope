using DataAccess.Models.Direcciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text;

namespace DataAccess.Models
{
    public class Denuncia : Base
    {
        public string NumeroDenunciaPolicia { get; set; }
        public DateTime FechaDenuncia { get; set; }
        public ICollection<DireccionDesaparicion> LugarVisto { get; set; }
        public DateTime FechaDesaparicion { get; set; }
        public string HaciaDondeSeDirigiaDireccion { get; set; }
        public InformacionDesaparecido InformacionDesaparecido { get; set; }
        public ICollection<DenunciasPoliciasAsignado> PoliciasAsignados { get; set; }
        public PersonaDenunciante PersonaDenunciante { get; set; }
        

    }
}
