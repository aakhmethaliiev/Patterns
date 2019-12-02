namespace PizzaStoreApp.Model
{
    public class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Crated Reggiano Cheese");
        }
    }
}