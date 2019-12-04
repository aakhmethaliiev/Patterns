using System;

namespace BaristaApp
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void AddCondiments();

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected abstract void Brew();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}