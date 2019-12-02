using StarbuzzApp.Beverages;

namespace StarbuzzApp.Decorators
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }
    }
}