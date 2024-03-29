﻿using ETrade.Core;
using ETrade.DTO;
using ETrade.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Repos.Abstract
{
    public interface IUsersRep:IBaseRepository<Users>
    {
        Users CreateUser(Users users);
        UsersDTO Login(string userName, string password);
    }
}
