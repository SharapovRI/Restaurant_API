using Microsoft.AspNetCore.Mvc;
using Restaurant_API.Business_Logic_Layer;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortionController : Controller
    {
        private PortionLogic _portionLogic;

        public PortionController(PortionLogic portionLogic)
        {
            _portionLogic = portionLogic;
        }

        [HttpGet("GetPortions/!{tableID}")]
        public IEnumerable<Portion> GetPortions(int tableID)
        {
            return _portionLogic.GetPortions(tableID);
        }

        [HttpGet]
        public IEnumerable<Portion> GetPortions([FromBody]Table table)
        {
            return _portionLogic.GetPortions(table);
        }

        [HttpPost("Create/!{tableID}!{dishID}!{weight}")]
        public void Create(int tableID, int dishID, int weight)
        {
            _portionLogic.AddPortion(tableID, dishID, weight);
        }

        [HttpPost("Update")]
        public void Update([FromBody] Portion portion)
        {
            _portionLogic.UpdatePortion(portion);
        }

        [HttpPost("Remove")]
        public void Remove([FromBody] Portion portion)
        {
            _portionLogic.RemovePortion(portion);
        }

        [HttpPost("Remove/!{portionID}")]
        public void Remove(int portionID)
        {
            _portionLogic.RemovePortion(portionID);
        }
    }
}
