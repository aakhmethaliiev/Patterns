using System;
using System.Collections;
using CafeMenuApp.MenuComponents;

namespace CafeMenuApp.MenuItems
{
    public class MenuItem : MenuComponent, IEnumerable
    {
        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public override void Print()
        {
            Console.Write($" {Name}");
            if (Vegetarian)
            {
                Console.Write("(v)");
            }

            Console.WriteLine($", {Price}");
            Console.WriteLine($"      -- {Description}");
        }

        public override string Name { get; }
        public override string Description { get; }
        public override bool Vegetarian { get; }
        public override double Price { get; }
        public override IEnumerator GetEnumerator()
        {
            return null;
        }
    }
}