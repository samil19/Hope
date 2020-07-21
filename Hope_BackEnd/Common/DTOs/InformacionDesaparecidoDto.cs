using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DTOs
{
    public class InformacionDesaparecidoDto
    {
        public int IdColorOjos { get; set; }
        public string ColorOjos { get; set; }
        public int IdColorPiel { get; set; }
        public string ColorPiel { get; set; }
        public int IdColorCabello { get; set; }
        public string ColorCabello { get; set; }
        public int IdEstadoCuerpo { get; set; }
        public string EstadoCuerpo { get; set; }
        public int IdDiscapacidad { get; set; }
        public string Discapacidad { get; set; }
        public int IdDiscapacidadIntelectual { get; set; }
        public string DiscapacidadIntelectual { get; set; }
        public double Altura { get; set; }
    }
}
