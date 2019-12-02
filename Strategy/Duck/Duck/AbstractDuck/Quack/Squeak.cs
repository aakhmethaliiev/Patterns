using System;

namespace Duck.AbstractDuck.Quack
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak.");
        }
    }
}