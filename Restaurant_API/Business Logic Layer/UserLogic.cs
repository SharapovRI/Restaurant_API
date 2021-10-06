using Restaurant_API.Data_Access_Layer;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Business_Logic_Layer
{
    public class UserLogic
    {
        private UsersService _usersService;
        
        public UserLogic(UsersService usersService)
        {
            _usersService = usersService;
        }
        public User GetUser(string login, string password)
        {
            return _usersService.Get(login, password);
        }
    }
}
