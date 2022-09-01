using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class Product
    {

        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string _Name, decimal _Price)
        {
            Name = _Name;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
    }
}
