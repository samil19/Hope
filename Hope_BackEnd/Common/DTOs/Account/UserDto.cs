using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DTOs.Account
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IpRegistro { get; set; }
        public PersonaDto Persona { get; set; }
    }
}
