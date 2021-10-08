using Restaurant_API.Data_Access_Layer;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Business_Logic_Layer
{
    public class PortionLogic
    {
        private PortionRepository _portionRepository;

        public PortionLogic(PortionRepository portionRepository)
        {
            _portionRepository = portionRepository;
        }

        public List<Portion> GetDishes()
        {
        }
    }
}
