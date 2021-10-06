using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Models
{
    public class User
    {
        public int id { get; set; }
        
        public string login { get; set; }

        public string password { get; set; }
    }
}
