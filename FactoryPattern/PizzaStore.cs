namespace FactoryPattern
{
    internal abstract class PizzaStore
    {
        internal abstract Pizza CreatePizza(PizzaType pizzaType);

        internal Pizza OrderPizza(PizzaType pizzaType)
        {
            var pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
