using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class Orders
    {
        public List<Pizza> OrderedPizzas { get; set; } = new List<Pizza>();
        public double TotalPrice { get; private set; } = 0;
        public void Add(Pizza pizza)
        {
            OrderedPizzas.Add(pizza);
            TotalPrice += pizza.Price;
        }
        public void Display() => Console.WriteLine(string.Join(" ", OrderedPizzas) + "\n" + nameof(TotalPrice) + TotalPrice);
    }
}
