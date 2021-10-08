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
        private UsersRepository _usersRepository;
        
        public UserLogic(UsersRepository usersService)
        {
            _usersRepository = usersService;
        }
        public User GetUser(string login, string password)
        {
            return _usersRepository.Get(login, password);
        }
    }
}
