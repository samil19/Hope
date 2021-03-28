﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DTOs.Account
{
    public class LoggedUserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public PersonaDto Persona { get; set; }
    }
}
