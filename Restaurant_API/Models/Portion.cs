using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Models
{
    public class Portion
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int weight { get; set; }

        [Required]
        public int dish_id { get; set; }

        [ForeignKey("dish_id")]
        public Dish Dish { get; set; }

        [Required]
        public int table_id { get; set; }

        [ForeignKey("table_id")]
        public Table Table { get; set; }
    }
}
