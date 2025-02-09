using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class Pizza
    {
        public string Name { get; private set; }
        public PizzaSize Size { get; private set; }
        public double Price { get; private set; }

        public Pizza(string name, PizzaSize size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        public void DisplayInfo() => Console.WriteLine($"Name: {Name}\nSize: {Size}\nPrice: {Price}");
        
    }
}
