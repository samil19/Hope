using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models.Logging
{
    public class Log : Base
    {
        
        public string ElementTable { get; set; }
        public int ElementId { get; set; }
        public int LogInId { get; set; }
        public DateTime Fecha { get; set; }
        public string Accion { get; set; }
        public LogIn LogIn { get; set; }

    }
}
