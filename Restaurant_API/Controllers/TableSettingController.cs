
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
    public class TableSettingController : Controller
    {
        private TableSettingLogic _tableSettingLogic;

        public TableSettingController(TableSettingLogic tableSettingLogic)
        {
            _tableSettingLogic = tableSettingLogic;
        }

        [HttpGet("GetTableSettings/!{tableID}")]
        public IEnumerable<TableSetting> GetTableSettings(int tableID)
        {
            return _tableSettingLogic.GetTableSettings(tableID);
        }

        [HttpGet]
        public IEnumerable<TableSetting> GetTableSettings([FromBody] Table table)
        {
            return _tableSettingLogic.GetTableSettings(table);
        }

        [HttpPost("Create/!{table_id}!{serving_item_id}")]
        public void Create(int table_id, int serving_item_id)
        {
            _tableSettingLogic.AddTableSetting(table_id, serving_item_id);
        }

        [HttpPost("Update")]
        public void Update([FromBody] TableSetting tableSetting)
        {
            _tableSettingLogic.UpdateTableSetting(tableSetting);
        }

        [HttpPost("Remove")]
        public void Remove([FromBody] TableSetting tableSetting)
        {
            _tableSettingLogic.RemoveTableSetting(tableSetting);
        }

        [HttpPost("Remove/!{tableSettingID}")]
        public void Remove(int tableSettingID)
        {
            _tableSettingLogic.RemoveTableSetting(tableSettingID);
        }
    }
}
