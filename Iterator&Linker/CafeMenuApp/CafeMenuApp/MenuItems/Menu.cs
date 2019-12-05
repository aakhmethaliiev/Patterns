using System;
using System.Collections;
using CafeMenuApp.MenuComponents;

namespace CafeMenuApp.MenuItems
{
    public class Menu : MenuComponent
    {
        private readonly ArrayList _menuComponents = new ArrayList();

        public Menu(string name, string description)
        {
            Description = description;
            Name = name;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Print()
        {
            Console.Write($"\n{Name}");
            Console.WriteLine($", {Description}");
            Console.WriteLine("------------------");

            foreach (MenuComponent component in _menuComponents)
            {
                component.Print();
            }
        }

        public override string Name { get; }

        public override string Description { get; }
        public override IEnumerator GetEnumerator()
        {
            return _menuComponents.GetEnumerator();
        }
    }
}