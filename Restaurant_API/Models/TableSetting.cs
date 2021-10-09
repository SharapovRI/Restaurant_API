using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Models
{
    public class TableSetting: IEntity
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int serving_item_id { get; set; }

        [ForeignKey("serving_item_id")]
        public ServingItem ServingItem { get; set; }

        [Required]
        public int table_id { get; set; }

        [ForeignKey("table_id")]
        public Table Table { get; set; }
    }
}
