using System;
using PizzaStoreApp.PizzaStores;

namespace PizzaStoreApp
{
    internal class Program
    {
        private static void Main()
        {
            PizzaStore nyStore = new NyPizzaStore();

            var pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");
            
            Console.ReadKey();
        }
    }
}
