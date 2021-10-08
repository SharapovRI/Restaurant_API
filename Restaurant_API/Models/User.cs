using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Models
{
    public class User:IEntity
    {
        public int id { get; set; }
        
        public string login { get; set; }

        public string password { get; set; }

        public int table_id { get; set; }

        [ForeignKey("table_id")]
        public Table Table { get; set; }
    }
}
