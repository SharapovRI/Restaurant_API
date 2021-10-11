using Restaurant_API.Data_Access_Layer;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Business_Logic_Layer
{
    public class TableLogic
    {
        private TableRepository<Table> _tableRepository;

        public TableLogic(TableRepository<Table> tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public Table GetTable(int tableID)
        {
            return _tableRepository.Get(tableID);
        }

        public Table AddTable(int user_id, string table_name)
        {
            User user = _tableRepository.GetRelatedUser(user_id);
            if (user.Table == null)
            {
                Table table = new Table { user_id = user_id, table_name = table_name };
                return _tableRepository.Create(table);
            }
            else throw new Exception("This user already contains a table");
        }

        public Table AddTable(User user, string table_name)
        {
            if (user.Table == null)
            {
                Table table = new Table { user_id = user.id, table_name = table_name };
                return _tableRepository.Create(table);
            }
            else throw new Exception("This user already contains a table");
        }

        public Table UpdateTable(Table table)
        {
            return _tableRepository.Update(table);
        }

        public Table RemoveTable(int tableID)
        {
            return _tableRepository.Remove(tableID);
        }

        public Table RemoveTable(Table table)
        {
            return _tableRepository.Remove(table);
        }
    }
}
