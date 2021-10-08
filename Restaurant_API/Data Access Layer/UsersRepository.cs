using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class UsersRepository<TEntity> : Repository<TEntity> where TEntity : User
    {
        private readonly ApplicationContext _db;

        public UsersRepository(ApplicationContext db)
            :base(db)
        {
            _db = db;
        }

        public User Get(string login, string password) =>
            _db.users.Include(u => u.Table).FirstOrDefault(user => user.login == login && user.password == password);


        public async Task<User> CreateAsync(User user)
        {
            await _db.users.AddAsync(user);
            _db.SaveChanges();
            return user;
        }

        public new List<User> Get() =>
            _db.users.ToList();

        public async Task<User> GetAsync(int id) =>
            await _db.users.FirstOrDefaultAsync(user => user.id == id);        
    }
}
