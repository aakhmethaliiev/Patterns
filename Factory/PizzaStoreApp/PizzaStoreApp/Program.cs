using System;
using PizzaStoreApp.PizzaStores;

namespace PizzaStoreApp
{
    internal class Program
    {
        private static void Main()
        {
            PizzaStore nyStore = new NyPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            var pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName}\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.GetName}\n");

            Console.ReadKey();
        }
    }
}
