using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class Menu
    {
        public List<Pizza> Pizzas { get; private set; } = [];
        public void Add(Pizza pizza) => Pizzas.Add(pizza);
        public void DisplayPizzas()
        {
            foreach (var pizza in Pizzas)
            {
                pizza.DisplayInfo();
            }
        }
    }
}
