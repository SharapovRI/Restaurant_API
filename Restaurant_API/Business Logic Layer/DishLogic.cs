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
        private DishesRepository _usersRepository;

        public DishLogic(DishesRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public List<Dish> GetDishes()
        {
            return _usersRepository.Get();
        }

        public Dish GetDish(int id)
        {
            return _usersRepository.Get(id);
        }

        public Dish GetDish(string name)
        {
            return _usersRepository.Get(name);
        }

        public Dish Update(Dish dish)
        {
            return _usersRepository.Update(dish);
        }
        public Dish Add(string name)
        {
            Dish dish = new Dish { name = name };
            return _usersRepository.Create(dish);
        }

        public Dish Remove(string name)
        {
            return _usersRepository.Remove(name);
        }

        public Dish Remove(Dish dish)
        {
            return _usersRepository.Remove(dish);
        }

        public Dish Remove(int id)
        {
            return _usersRepository.Remove(id);
        }
    }
}
