using System;

namespace Duck.AbstractDuck.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}