using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Business_Logic_Layer
{
    interface IEntityLogic
    {
        public List<IEntity> GetDishes();
        public IEntity GetDish(int id);
        public IEntity Update(IEntity instance);
        public IEntity Remove(IEntity instance);
        public IEntity Remove(int id);
    }
}
