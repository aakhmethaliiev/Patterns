using System;

namespace Duck.AbstractDuck.Quack
{
    public class CanQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack.");
        }
    }
}