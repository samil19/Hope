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
        public InformacionPolicia InformacionPolicia { get; set; }
        public Denuncia Denuncia { get; set; }

    }
}
