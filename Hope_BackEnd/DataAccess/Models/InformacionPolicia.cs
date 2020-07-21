using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class InformacionPolicia
    {
        public int Id { get; set; }
        public int IdRango { get; set; }
        public int IdSupervisor { get; set; }
        [ForeignKey("Persona")]
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }
        public ICollection<DenunciasPoliciasAsignado> DenunciasAsignadas { get; set; }
    }
}
