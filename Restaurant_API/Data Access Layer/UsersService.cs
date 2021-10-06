using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class UsersService
    {
        private readonly List<User> _users;

        public UsersService()
        {
            ApplicationContext db = new ApplicationContext();
            _users = db.users.ToList();
        }

        public User Get(string login, string password) =>
            _users.FirstOrDefault(user => user.login == login && user.password == password);

        /*public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public User Get(string login, string password) =>
            _users.Find<User>(user => user.login == login && user.password == password).FirstOrDefault();

        public List<User> Get() =>
            _users.Find(user => true).ToList();

        public User Get(int id) =>
            _users.Find<User>(user => user.id == id).FirstOrDefault();

        public void Update(int id, User userEd) =>
            _users.ReplaceOne(user => user.id == id, userEd);

        public void Remove(User userEd) =>
            _users.DeleteOne(user => user.id == userEd.id);

        public void Remove(int id) =>
            _users.DeleteOne(user => user.id == id);*/
    }
}
