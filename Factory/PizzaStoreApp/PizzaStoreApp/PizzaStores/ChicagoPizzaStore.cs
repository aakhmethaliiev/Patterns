using PizzaStoreApp.Model;

namespace PizzaStoreApp.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
            }

            return null;
        }
    }
}