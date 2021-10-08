using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationContext _db;
        private readonly DbSet<TEntity> _set;

        public Repository(ApplicationContext db)
        {
            _db = db;
            _set = db.Set<TEntity>();
        }
        public TEntity Create(TEntity instance)
        {
            _set.Add(instance);
            _db.SaveChanges();
            return instance;
        }

        public virtual List<TEntity> Get() =>
            _set.ToList();

        public TEntity Get(int id) =>
            _set.FirstOrDefault(instance => ((IEntity)instance).id == id);

        public TEntity Remove(TEntity instance)
        {
            _set.Remove(instance);
            _db.SaveChanges();
            return instance;
        }

        public TEntity Remove(int id)
        {
            TEntity instance = Get(id);
            _set.Remove(instance);
            _db.SaveChanges();
            return instance;
        }

        public TEntity Update(TEntity instance)
        {
            _set.Update(instance);
            _db.SaveChanges();
            return instance;
        }
    }
}
