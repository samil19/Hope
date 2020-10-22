using DataAccess.EntityFramework;
using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Models.Account;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(HopeContext context) : base(context) { }
    }
}
