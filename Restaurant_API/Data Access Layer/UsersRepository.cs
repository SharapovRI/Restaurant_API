using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class UsersRepository: IUsersRepository
    {
        private readonly ApplicationContext _db;

        public UsersRepository(ApplicationContext db)
        {
            _db = db;
        }

        public User Get(string login, string password) =>
            _db.users.Include(u => u.Table).FirstOrDefault(user => user.login == login && user.password == password);

        public User Create(User user)
        {
            _db.users.Add(user);
            _db.SaveChanges();
            return user;
        }

        public async Task<User> CreateAsync(User user)
        {
            await _db.users.AddAsync(user);
            _db.SaveChanges();
            return user;
        }

        public List<User> Get() =>
            _db.users.ToList();


        public User Get(int id) =>
            _db.users.FirstOrDefault(user => user.id == id);

        public async Task<User> GetAsync(int id) =>
            await _db.users.FirstOrDefaultAsync(user => user.id == id);

        public User Update(User user)
        {
            _db.users.Update(user);
            _db.SaveChanges();
            return user;
        }

        public User Remove(User user)
        {
            _db.users.Remove(user);
            _db.SaveChanges();
            return user;
        }

        public User Remove(int id)
        {
            User user = Get(id);
            _db.users.Remove(user);
            _db.SaveChanges();
            return user;
        }
    }
}
