using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class DishesRepository
    {
        private readonly ApplicationContext _db;

        public DishesRepository(ApplicationContext db)
        {
            _db = db;
        }

        public Dish Create(Dish dish)
        {
            _db.dishes.Add(dish);
            _db.SaveChanges();
            return dish;
        }

        public async Task<Dish> CreateAsync(Dish dish)
        {
            await _db.dishes.AddAsync(dish);
            _db.SaveChanges();
            return dish;
        }

        public List<Dish> Get() =>
            _db.dishes.ToList();


        public Dish Get(int id) =>
            _db.dishes.FirstOrDefault(dish => dish.id == id);

        public async Task<Dish> GetAsync(int id) =>
            await _db.dishes.FirstOrDefaultAsync(dish => dish.id == id);

        public Dish Get(string name) =>
            _db.dishes.FirstOrDefault(dish => dish.name == name);

        public async Task<Dish> GetAsync(string name) =>
            await _db.dishes.FirstOrDefaultAsync(dish => dish.name == name);

        public Dish Update(Dish dish)
        {
            _db.dishes.Update(dish);
            _db.SaveChanges();
            return dish;
        }

        public Dish Remove(Dish dish)
        {
            _db.dishes.Remove(dish);
            _db.SaveChanges();
            return dish;
        }

        public Dish Remove(int id)
        {
            Dish dish = Get(id);
            _db.dishes.Remove(dish);
            _db.SaveChanges();
            return dish;
        }
        public Dish Remove(string name)
        {
            Dish dish = Get(name);
            _db.dishes.Remove(dish);
            _db.SaveChanges();
            return dish;
        }
    }
}
