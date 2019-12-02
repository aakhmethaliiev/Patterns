using System;

namespace Duck.AbstractDuck.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying.");
        }
    }
}