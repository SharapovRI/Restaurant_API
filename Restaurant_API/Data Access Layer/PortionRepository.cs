using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class PortionRepository<TEntity> : Repository<TEntity> where TEntity : Portion
    {
        private readonly ApplicationContext _db;

        public PortionRepository(ApplicationContext db)
            : base(db)
        {
            _db = db;
        }

        public async Task<Portion> CreateAsync(Portion portion)
        {
            await _db.portions.AddAsync(portion);
            _db.SaveChanges();
            return portion;
        }
        public new List<Portion> Get(int tableID)
        {
            Portion portion = _db.portions.Include(p => p.Table).First(port => port.table_id == tableID);
            return portion.Table.Portions;
        }

        public List<Portion> Get(Table table)
        {
            return table.Portions;
        }

        public async Task<Portion> GetAsync(int id) =>
            await _db.portions.FirstOrDefaultAsync(portion => portion.id == id);
    }
}
