using PizzaStoreApp.Ingredients;
using PizzaStoreApp.Ingredients.Cheeses;
using PizzaStoreApp.Ingredients.Clams;
using PizzaStoreApp.Ingredients.Doughs;
using PizzaStoreApp.Ingredients.Pepperonies;
using PizzaStoreApp.Ingredients.Sauces;
using PizzaStoreApp.Ingredients.Veggies;

namespace PizzaStoreApp.IngredientsFactories
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggieses();
        IPepperoni CreatePapperone();
        IClams CreateClam();
    }
}