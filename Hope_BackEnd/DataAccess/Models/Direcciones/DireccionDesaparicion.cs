﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models.Direcciones
{
    public class DireccionDesaparicion : Base
    {
        
        [ForeignKey("Denuncia")]
        public int IdDenuncia { get; set; }
        public Denuncia Denuncia { get; set; }

    }
}
