using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class PortionRepository
    {
        private readonly ApplicationContext _db;

        public PortionRepository(ApplicationContext db)
        {
            _db = db;
        }

        public Portion Create(Portion portion)
        {
            _db.portions.Add(portion);
            _db.SaveChanges();
            return portion;
        }

        public async Task<Portion> CreateAsync(Portion portion)
        {
            await _db.portions.AddAsync(portion);
            _db.SaveChanges();
            return portion;
        }
    }
}
