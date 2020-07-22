using DataAccess.Models.Direcciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido{ get; set; }
        public string SegundoApellido { get; set; }
        public string Apodo { get; set; }
        public int Edad { get; set; }
        //Se agrego aqui para poder usar la direccion en notificaciones reactivas por zona, tanto para policia como para ciudadanos
        public ICollection<DireccionVivienda> DireccionVivienda { get; set; }
    }
}
