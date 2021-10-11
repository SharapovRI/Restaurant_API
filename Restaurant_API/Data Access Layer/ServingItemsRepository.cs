using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class ServingItemsRepository<TEntity> : Repository<TEntity> where TEntity : ServingItem
    {
        private readonly ApplicationContext _db;

        public ServingItemsRepository(ApplicationContext db)
            : base(db)
        {
            _db = db;
        }

        public async Task<ServingItem> CreateAsync(ServingItem servingItem)
        {
            await _db.serving_items.AddAsync(servingItem);
            _db.SaveChanges();
            return servingItem;
        }

        public new List<ServingItem> Get() =>
            _db.serving_items.Include(ts => ts.TableSettings).ToList();

        public async Task<ServingItem> GetAsync(int id) =>
            await _db.serving_items.Include(ts => ts.TableSettings).FirstOrDefaultAsync(servingItem => servingItem.id == id);

        public ServingItem Get(string name) =>
            _db.serving_items.Include(ts => ts.TableSettings).FirstOrDefault(servingItem => servingItem.name == name);

        public async Task<ServingItem> GetAsync(string name) =>
            await _db.serving_items.Include(ts => ts.TableSettings).FirstOrDefaultAsync(servingItem => servingItem.name == name);

        public ServingItem Remove(string name)
        {
            ServingItem servingItem = Get(name);
            _db.serving_items.Remove(servingItem);
            _db.SaveChanges();
            return servingItem;
        }
    }
}
