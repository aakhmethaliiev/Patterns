using PizzaStoreApp.Ingredients;
using PizzaStoreApp.Ingredients.Cheeses;
using PizzaStoreApp.Ingredients.Clams;
using PizzaStoreApp.Ingredients.Doughs;
using PizzaStoreApp.Ingredients.Pepperonies;
using PizzaStoreApp.Ingredients.Sauces;
using PizzaStoreApp.Ingredients.Veggies;

namespace PizzaStoreApp.IngredientsFactories
{
    public class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IVeggies[] CreateVeggieses()
        {
            IVeggies[] veggies = {new Garlic(), new Onion(), new Mushroom(), new RedPepper()};
            return veggies;
        }

        public IPepperoni CreatePapperone()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClam()
        {
            return new FreshClams();
        }
    }
}