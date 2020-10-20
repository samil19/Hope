using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models.Account
{
    public class User : Base
    {
        public int RolId { get; set; }
        public int PersonaId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Persona Persona { get; set; }
        public Rol Rol { get; set; }

    }
}
