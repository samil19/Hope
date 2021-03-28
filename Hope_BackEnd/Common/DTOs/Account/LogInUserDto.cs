using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DTOs.Account
{
    public class LogInUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ip { get; set; }
     }
}
