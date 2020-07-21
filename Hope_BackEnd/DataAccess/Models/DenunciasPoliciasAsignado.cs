using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class DenunciasPoliciasAsignado
    {
        public int Id { get; set; }
        [ForeignKey("InformacionPoliciaAsignado")]
        public int IdInformacionPoliciaAsignado { get; set; }
        public InformacionPolicia InformacionPolicia { get; set; }
        [ForeignKey("Denuncia")]
        public int IdDenuncia { get; set; }
        public Denuncia Denuncia { get; set; }

    }
}
