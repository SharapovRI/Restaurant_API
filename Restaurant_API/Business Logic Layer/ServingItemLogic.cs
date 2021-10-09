using Restaurant_API.Data_Access_Layer;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Business_Logic_Layer
{
    public class ServingItemLogic
    {
        private ServingItemsRepository<ServingItem> _servingItemsRepository;

        public ServingItemLogic(ServingItemsRepository<ServingItem> servingItemsRepository)
        {
            _servingItemsRepository = servingItemsRepository;
        }
        public ServingItem Add(string name)
        {
            ServingItem dish = new ServingItem { name = name };
            return (ServingItem)_servingItemsRepository.Create(dish);
        }

        public List<ServingItem> GetServingItems()
        {
            return _servingItemsRepository.Get();
        }

        public ServingItem GetServingItem(int id)
        {
            return (ServingItem)_servingItemsRepository.Get(id);
        }

        public ServingItem GetServingItem(string name)
        {
            return _servingItemsRepository.Get(name);
        }

        public ServingItem Update(ServingItem dish)
        {
            return (ServingItem)_servingItemsRepository.Update(dish);
        }

        public ServingItem Remove(string name)
        {
            return _servingItemsRepository.Remove(name);
        }

        public ServingItem Remove(ServingItem dish)
        {
            return (ServingItem)_servingItemsRepository.Remove(dish);
        }

        public ServingItem Remove(int id)
        {
            return (ServingItem)_servingItemsRepository.Remove(id);
        }
    }
}
