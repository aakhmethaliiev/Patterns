using System;
using Duck.AbstractDuck.Fly;
using Duck.AbstractDuck.Quack;

namespace Duck.ConcretDucks
{
    public class MallardDuck : AbstractDuck.Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new CanQuack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}