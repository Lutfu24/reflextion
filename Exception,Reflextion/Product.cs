using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Reflextion
{
    internal class Product
    {
        public string No;
        public string Name;
        public double Price;
        public Food Type;

        public Product(string no, string name, double price, Food type)
        {
            No = no;
            Name = name;
            Price = price;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name} price:{Price} no:{No}";
        }
    }
}
