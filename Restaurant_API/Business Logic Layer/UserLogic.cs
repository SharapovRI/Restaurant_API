using Restaurant_API.Data_Access_Layer;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_API.Business_Logic_Layer
{
    public class UserLogic
    {
        private UsersRepository<User> _usersRepository;
        
        public UserLogic(UsersRepository<User> usersService)
        {
            _usersRepository = usersService;
        }
        public User GetUser(string login, string password)
        {
            return _usersRepository.Get(login, ToSha256(password));
        }

        private string ToSha256(string text)
        {
            byte[] data = Encoding.Default.GetBytes(text);
            var result = new SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }
    }
}
