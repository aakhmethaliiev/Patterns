using PizzaStoreApp.Model;

namespace PizzaStoreApp.PizzaStores
{
    public class NyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NyStyleCheesePizza();
            }

            return null;
        }
    }
}