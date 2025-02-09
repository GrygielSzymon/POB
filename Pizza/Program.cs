namespace Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizza1 = new Pizza("Paperoni", PizzaSize.Medium, 50.49);
            var pizza2 = new Pizza("Capriciosa", PizzaSize.Large, 50.49);
            var pizza3 = new Pizza("Margherita", PizzaSize.Small, 30.59);
            var pizza4 = new Pizza("Quattro Formagi", PizzaSize.Medium, 50.49);

            var orders = new Orders();
            orders.Add(pizza1);
            orders.Add(pizza2);
            orders.Add(pizza3);
            orders.Add(pizza4);

            orders.Display();

            var menu = new Menu();
            menu.Add(pizza1);
            menu.Add(pizza2);
            menu.Add(pizza3);

            menu.DisplayPizzas();
        }
    }
}
