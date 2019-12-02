using System;
using System.Collections;

namespace PizzaStoreApp.Model
{
    public abstract class Pizza
    {
        protected string Dough;
        protected string Sauce;
        protected ArrayList Toppings = new ArrayList();
        protected string Name;

        public virtual void Preapre()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough... ");
            Console.WriteLine("Adding sauce... ");
            Console.WriteLine("Adding toppings: ");
            foreach (var t in Toppings)
            {
                Console.WriteLine("  " + t);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName => Name;
    }
}