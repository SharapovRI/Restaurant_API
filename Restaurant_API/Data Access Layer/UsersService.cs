using MongoDB.Driver;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class UsersService: IUsersService
    {
        private readonly IMongoCollection<User> _users;

        public UsersService(IRestaurant_API_DataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UsersCollectionName);
        }
        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public User Get(string login, string password) =>
            _users.Find<User>(user => user.Login == login && user.Password == password).FirstOrDefault();

        public List<User> Get() =>
            _users.Find(user => true).ToList();

        public User Get(string id) =>
            _users.Find<User>(user => user.Id == id).FirstOrDefault();

        public void Update(string id, User userEd) =>
            _users.ReplaceOne(user => user.Id == id, userEd);

        public void Remove(User userEd) =>
            _users.DeleteOne(user => user.Id == userEd.Id);

        public void Remove(string id) =>
            _users.DeleteOne(user => user.Id == id);
    }
}
