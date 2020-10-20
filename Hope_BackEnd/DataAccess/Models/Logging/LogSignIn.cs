using DataAccess.Models.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models.Logging
{
    public class LogIn : Base
    {
        
        public int UserId { get; set; }
        public string Ip { get; set; }
        public DateTime FechaLogIn { get; set; }
        public  DateTime FechaLogOut { get; set; }
        public int SessionTime { get; set; }
        public string LogInType { get; set; }
        public User User { get; set; }
    
    }
}
