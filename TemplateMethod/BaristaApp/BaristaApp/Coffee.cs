using System;

namespace BaristaApp
{
    public class Coffee : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}