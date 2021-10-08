using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    interface IRepository<TEntity> where TEntity : class
    {
        public TEntity Create(TEntity instance);
        public List<TEntity> Get();
        public TEntity Get(int id);
        public TEntity Update(TEntity instance);
        public TEntity Remove(TEntity instance);
        public TEntity Remove(int id);
    }
}
