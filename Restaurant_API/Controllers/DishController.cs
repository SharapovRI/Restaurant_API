using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class DishController : ControllerBase
    {
        private DishLogic _dishLogic;

        public DishController(DishLogic dishLogic)
        {
            _dishLogic = dishLogic;
        }
        
        [HttpGet]
        public IEnumerable<Dish> GetDishes()
        {
            return _dishLogic.GetDishes();
        }

        [HttpGet("Details/!{id}")]
        public Dish Details(int id)
        {
            return _dishLogic.GetDish(id);
        }

        [HttpGet("Details/{name}")]
        public Dish Details(string name)        
        {
            return _dishLogic.GetDish(name);
        }

        // POST: DishController/Create
        [HttpPost("Create/{name}")]
        public void Create(string name)
        
        {
            _dishLogic.Add(name);
        }

        // POST: DishController/Edit/5
        [HttpPost("Edit")]
        public void Edit([FromBody] Dish dish)
        {
            _dishLogic.Update(dish);
        }

        // POST: DishController/Delete/5
        [HttpPost("Delete")]
        public void Delete([FromBody] Dish dish)
        {
            _dishLogic.Remove(dish);
        }

        [HttpPost("Delete/!{id}")]
        public void Delete(int id)
        {
            _dishLogic.Remove(id);
        }

        [HttpPost("Delete/{name}")]
        public void Delete(string name)
        {
            _dishLogic.Remove(name);
        }
    }
}
