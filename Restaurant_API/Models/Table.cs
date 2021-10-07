using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Models
{
    public class Table
    {
        [Key]
        public int id { get; set; }

        public string table_name { get; set; }

        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public User User { get; set; }
    }
}
