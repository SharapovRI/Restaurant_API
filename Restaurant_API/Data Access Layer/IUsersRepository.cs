using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    interface IUsersRepository
    {
        public User Create(User user);
        public User Get(string login, string password);
        public List<User> Get();
        public User Get(int id);
        public User Update(User user);
        public User Remove(User user);
        public User Remove(int id);
    }
}
