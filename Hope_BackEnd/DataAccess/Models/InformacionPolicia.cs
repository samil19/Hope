using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class InformacionPolicia : Base
    {
        
        public int IdRango { get; set; }
        public int IdSupervisor { get; set; }
        public Persona Persona { get; set; }
    }
}
