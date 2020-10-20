using DataAccess.Models.Direcciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class InformacionDesaparecido : Base
    {
        
        public int IdColorOjos { get; set; }
        public int IdColorPiel { get; set; }
        public int IdEstadoCuerpo { get; set; }
        public Discapacidad Discapacidad { get; set; }
        public Cabello Cabello { get; set; }
        public Barba Barba { get; set; }
        public ICollection<Tatuaje> Tatuajes { get; set; }
        public ICollection<Ropa> Ropas { get; set; }
        public double Altura { get; set; }
        public int Peso { get; set; }
        public string Apariencia { get; set; }
        public string TratoEspecial { get; set; }
        [ForeignKey("Denuncia")]
        public int IdDenuncia { get; set; }
        public ICollection<Denuncia> Denuncias { get; set; }
        [ForeignKey("Persona")]
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }


    }
}
