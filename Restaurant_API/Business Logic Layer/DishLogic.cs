using Restaurant_API.Data_Access_Layer;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Business_Logic_Layer
{
    public class DishLogic
    {
        private DishesRepository<Dish> _dishesRepository;

        public DishLogic(DishesRepository<Dish> dishesRepository)
        {
            _dishesRepository = dishesRepository;
        }
        public Dish Add(string name)
        {
            Dish dish = new Dish { name = name };
            return (Dish)_dishesRepository.Create(dish);
        }

        public List<Dish> GetDishes()
        {
            return _dishesRepository.Get();
        }

        public Dish GetDish(int id)
        {
            return (Dish)_dishesRepository.Get(id);
        }

        public Dish GetDish(string name)
        {
            return _dishesRepository.Get(name);
        }

        public Dish Update(Dish dish)
        {
            return (Dish)_dishesRepository.Update(dish);
        }        

        public Dish Remove(string name)
        {
            return _dishesRepository.Remove(name);
        }

        public Dish Remove(Dish dish)
        {
            return (Dish)_dishesRepository.Remove(dish);
        }

        public Dish Remove(int id)
        {
            return (Dish)_dishesRepository.Remove(id);
        }
    }
}
