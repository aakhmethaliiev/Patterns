using System;
using System.Collections;
using CafeMenuApp.MenuComponents;

namespace CafeMenuApp
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("\nVEGETARIAN\n----");
            foreach (MenuComponent menuComponents in _allMenus)
            {
                foreach (MenuComponent menuComponent in menuComponents)
                {
                    if (menuComponent.Vegetarian)
                    {
                        menuComponent.Print();
                    }
                }
            }
        }
    }
}