using StarbuzzApp.Beverages;

namespace StarbuzzApp.Decorators
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }
    }
}