using Restaurant_API.Data_Access_Layer;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Business_Logic_Layer
{
    public class TableSettingLogic
    {
        private TableSettingRepository<TableSetting> _tableSettingRepository;

        public TableSettingLogic(TableSettingRepository<TableSetting> tableSettingRepository)
        {
            _tableSettingRepository = tableSettingRepository;
        }

        public List<TableSetting> GetTableSettings(int tableID)
        {
            return _tableSettingRepository.Get(tableID);
        }

        public List<TableSetting> GetTableSettings(Table table)
        {
            return _tableSettingRepository.Get(table);
        }

        public TableSetting AddTableSetting(int table_id, int serving_item_id)
        {
            TableSetting tableSetting = new TableSetting { serving_item_id = serving_item_id, table_id = table_id };
            return _tableSettingRepository.Create(tableSetting);
        }

        public TableSetting AddTableSetting(Table table, int serving_item_id)
        {
            TableSetting tableSetting = new TableSetting { serving_item_id = serving_item_id, table_id = table.id };
            return _tableSettingRepository.Create(tableSetting);
        }

        public TableSetting UpdateTableSetting(TableSetting tableSetting)
        {
            return _tableSettingRepository.Update(tableSetting);
        }

        public TableSetting RemoveTableSetting(int tableSettingID)
        {
            return _tableSettingRepository.Remove(tableSettingID);
        }

        public TableSetting RemoveTableSetting(TableSetting tableSetting)
        {
            return _tableSettingRepository.Remove(tableSetting);
        }
    }
}
