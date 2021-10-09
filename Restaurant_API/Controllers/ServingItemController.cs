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
    public class ServingItemController : Controller
    {
        private ServingItemLogic _servingItemLogic;

        public ServingItemController(ServingItemLogic servingItemLogic)
        {
            _servingItemLogic = servingItemLogic;
        }

        [HttpGet]
        public IEnumerable<ServingItem> GetServingItems()
        {
            return _servingItemLogic.GetServingItems();
        }

        [HttpGet("Details/!{id}")]
        public ServingItem Details(int id)
        {
            return _servingItemLogic.GetServingItem(id);
        }

        [HttpGet("Details/{name}")]
        public ServingItem Details(string name)
        {
            return _servingItemLogic.GetServingItem(name);
        }

        // POST: DishController/Create
        [HttpPost("Create/{name}")]
        public void Create(string name)
        {
            _servingItemLogic.Add(name);
        }

        // POST: DishController/Edit/5
        [HttpPost("Edit")]
        public void Edit([FromBody] ServingItem servingItem)
        {
            _servingItemLogic.Update(servingItem);
        }

        // POST: DishController/Delete/5
        [HttpPost("Delete")]
        public void Delete([FromBody] ServingItem servingItem)
        {
            _servingItemLogic.Remove(servingItem);
        }

        [HttpPost("Delete/!{id}")]
        public void Delete(int id)
        {
            _servingItemLogic.Remove(id);
        }

        [HttpPost("Delete/{name}")]
        public void Delete(string name)
        {
            _servingItemLogic.Remove(name);
        }
    }
}
