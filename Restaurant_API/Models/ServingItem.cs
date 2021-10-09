using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Models
{
    public class ServingItem : IEntity
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public List<TableSetting> TableSettings { get; set; }
    }
}
