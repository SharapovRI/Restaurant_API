using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class TableRepository<TEntity> : Repository<TEntity> where TEntity : Models.Table
    {
        private readonly ApplicationContext _db;

        public TableRepository(ApplicationContext db)
            : base(db)
        {
            _db = db;
        }

        public async Task<Models.Table> CreateAsync(Models.Table table)
        {
            await _db.tables.AddAsync(table);
            _db.SaveChanges();
            return table;
        }
        public new Models.Table Get(int tableID)
        {
            return _db.tables.Include(p => p.Portions).Include(p => p.TableSettings).Include(p => p.User).FirstOrDefault(port => port.id == tableID);
        }

        public async Task<Models.Table> GetAsync(int id) =>
            await _db.tables.Include(p => p.Portions).Include(p => p.TableSettings).Include(p => p.User).FirstOrDefaultAsync(table => table.id == id);

        public User GetRelatedUser(int userID)
        {
            return _db.users.Include(t => t.Table).FirstOrDefault(user => user.id == userID);
        }
    }
}
