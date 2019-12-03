using System;
using PizzaStoreApp.Ingredients.Cheeses;
using PizzaStoreApp.Ingredients.Clams;
using PizzaStoreApp.Ingredients.Doughs;
using PizzaStoreApp.Ingredients.Pepperonies;
using PizzaStoreApp.Ingredients.Sauces;
using PizzaStoreApp.Ingredients.Veggies;

namespace PizzaStoreApp.Model
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        protected IDough Dough;
        protected ISauce Sauce;
        protected ICheese Cheese;
        protected IPepperoni Pepperoni;
        protected IClams Clam;
        
        protected IVeggies[] Toppings;

        public abstract void Preapre();

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

    }
}