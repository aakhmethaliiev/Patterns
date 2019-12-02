using System;
using Duck.AbstractDuck.Fly;
using Duck.AbstractDuck.Quack;

namespace Duck.ConcretDucks
{
    public class ModelDuck : AbstractDuck.Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new CanQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}