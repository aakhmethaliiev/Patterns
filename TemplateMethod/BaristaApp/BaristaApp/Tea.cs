using System;

namespace BaristaApp
{
    public class Tea : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}