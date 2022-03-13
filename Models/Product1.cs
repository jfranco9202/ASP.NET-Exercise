using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NathansCRUDWebsite.Models
{
    public class Product1
    {
        public Product1()
        {

        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
        public IEnumerable<Category> Categories { get; set; }


    }
}

