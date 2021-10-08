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
        private PortionRepository<Portion> _portionRepository;

        public PortionLogic(PortionRepository<Portion> portionRepository)
        {
            _portionRepository = portionRepository;
        }

        public List<Portion> GetPortions(int tableID)
        {
            return _portionRepository.Get(tableID);
        }

        public List<Portion> GetPortions(Table table)
        {
            return _portionRepository.Get(table);
        }

        public Portion AddPortion(int tableID, int dishID, int weight)
        {
            Portion portion = new Portion { dish_id = dishID, table_id = tableID, weight = weight };
            return _portionRepository.Create(portion);
        }

        public Portion AddPortion(Table table, int dishID, int weight)
        {
            Portion portion = new Portion { dish_id = dishID, table_id = table.id, weight = weight };
            return _portionRepository.Create(portion);
        }

        public Portion UpdatePortion(Portion portion)
        {
            return _portionRepository.Update(portion);
        }

        public Portion RemovePortion(int portionID)
        {
            return _portionRepository.Remove(portionID);
        }

        public Portion RemovePortion(Portion portion)
        {
            return _portionRepository.Remove(portion);
        }
    }
}
