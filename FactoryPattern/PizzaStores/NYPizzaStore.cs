using FactoryPattern.IngredientFactories;
using FactoryPattern.Pizzas;

namespace FactoryPattern.PizzaStores;

internal class NYPizzaStore : PizzaStore
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public NYPizzaStore()
    {
        _ingredientFactory = new NYIngredientFactory();
    }

    internal override Pizza CreatePizza(PizzaType pizzaType) => pizzaType switch
    {
        PizzaType.Clam => new ClamPizza(_ingredientFactory, "New York Style Clam Pizza"),
        PizzaType.Peppperoni => new PepperoniPizza(_ingredientFactory, "New York Style Pepperoni Pizza"),
        PizzaType.Veggie => new VeggiePizza(_ingredientFactory, "New York Style Veggie Pizza"),
        PizzaType.Cheese => new CheesePizza(_ingredientFactory, "New York Style Cheese Pizza"),
        _ => throw new ArgumentException("Not a valid NY Pizza!")
    };
}
