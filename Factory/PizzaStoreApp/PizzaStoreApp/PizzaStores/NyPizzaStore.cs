using PizzaStoreApp.IngredientsFactories;
using PizzaStoreApp.Model;

namespace PizzaStoreApp.PizzaStores
{
    public class NyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(new NyPizzaIngredientFactory());
                    pizza.Name = "New York Style Cheese Pizza";
                    break;
            }

            return pizza;
        }
    }
}