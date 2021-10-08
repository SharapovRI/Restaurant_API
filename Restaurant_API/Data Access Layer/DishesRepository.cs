using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class DishesRepository<TEntity> : Repository<TEntity> where TEntity : Dish
    {
        private readonly ApplicationContext _db;

        public DishesRepository(ApplicationContext db) 
            :base(db)
        {
            _db = db;
        }

        public async Task<Dish> CreateAsync(Dish dish)
        {
            await _db.dishes.AddAsync(dish);
            _db.SaveChanges();
            return dish;
        }

        public new List<Dish> Get() =>
            _db.dishes.ToList();

        public async Task<Dish> GetAsync(int id) =>
            await _db.dishes.FirstOrDefaultAsync(dish => dish.id == id);

        public Dish Get(string name) =>
            _db.dishes.FirstOrDefault(dish => dish.name == name);

        public async Task<Dish> GetAsync(string name) =>
            await _db.dishes.FirstOrDefaultAsync(dish => dish.name == name);
                
        public Dish Remove(string name)
        {
            Dish dish = Get(name);
            _db.dishes.Remove(dish);
            _db.SaveChanges();
            return dish;
        }
    }
}
