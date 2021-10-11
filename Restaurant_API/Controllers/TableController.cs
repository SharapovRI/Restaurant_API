using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class TableController : Controller
    {
        private TableLogic _tableLogic;

        public TableController(TableLogic tableLogic)
        {
            _tableLogic = tableLogic;
        }

        [HttpGet("GetTable/!{tableID}")]
        public Table GetTable(int tableID)
        {
            return _tableLogic.GetTable(tableID);
        }

        [HttpPost("Create/!{tableID}!{dishID}!{weight}")]
        public void Create(int user_id, string table_name)
        {
            try
            {
                _tableLogic.AddTable(user_id, table_name);
            }
            catch(Exception ex)
            { }
        }

        [HttpPost("Create")]
        public void Create(User user, string table_name)
        {
            try
            {
                _tableLogic.AddTable(user, table_name);
            }
            catch (Exception ex)
            { }
        }

        [HttpPost("Update")]
        public void Update([FromBody] Table table)
        {
            _tableLogic.UpdateTable(table);
        }

        [HttpPost("Remove")]
        public void Remove([FromBody] Table table)
        {
            _tableLogic.RemoveTable(table);
        }

        [HttpPost("Remove/!{tableID}")]
        public void Remove(int tableID)
        {
            _tableLogic.RemoveTable(tableID);
        }
    }
}
