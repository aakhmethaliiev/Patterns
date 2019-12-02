using System;
using Duck.AbstractDuck.Fly;
using Duck.ConcretDucks;

namespace Duck
{
    internal class Program
    {
        private static void Main()
        {
            AbstractDuck.Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            AbstractDuck.Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            Console.ReadKey();
        }
    }
}
