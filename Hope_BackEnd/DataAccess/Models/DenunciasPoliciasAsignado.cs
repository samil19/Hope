using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class DenunciasPoliciasAsignado : Base
    {
        
        public InformacionPolicia InformacionPolicia { get; set; }
        public Denuncia Denuncia { get; set; }

    }
}
