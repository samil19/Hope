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
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Salt { get; set; }
        [Required]
        public string IpRegistro { get; set; }
        public Persona Persona { get; set; }
        public Rol Rol { get; set; }

    }
}
