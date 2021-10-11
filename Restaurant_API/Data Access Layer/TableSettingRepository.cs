using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    public class TableSettingRepository<TEntity> : Repository<TEntity> where TEntity : TableSetting
    {
        private readonly ApplicationContext _db;

        public TableSettingRepository(ApplicationContext db)
            : base(db)
        {
            _db = db;
        }

        public async Task<TableSetting> CreateAsync(TableSetting tableSetting)
        {
            await _db.table_settings.AddAsync(tableSetting);
            _db.SaveChanges();
            return tableSetting;
        }
        public new List<TableSetting> Get(int tableID)
        {
            TableSetting tableSetting = _db.table_settings.Include(p => p.Table).Include(si => si.ServingItem).FirstOrDefault(tableSet => tableSet.table_id == tableID);
            return tableSetting.Table.TableSettings;
        }

        public List<TableSetting> Get(Table table)
        {
            return table.TableSettings;
        }

        public async Task<TableSetting> GetAsync(int id) =>
            await _db.table_settings.Include(p => p.Table).Include(si => si.ServingItem).FirstOrDefaultAsync(tableSet => tableSet.id == id);
    }
}
