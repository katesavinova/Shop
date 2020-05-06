using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoreName { set; get; }
        public string desc { set; get; }
        public List<Car>cars { set; get; }
    }
}
