using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class PersonaDenunciante
    {
        public int Id { get; set; }
        //Console diccionario
        public int IdParentesco { get; set; }
        public InformacionBasica InformacionBasica { get; set; }
    }
}
