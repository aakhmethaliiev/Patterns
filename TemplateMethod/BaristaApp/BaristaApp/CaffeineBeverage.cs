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

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected abstract void Brew();

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}