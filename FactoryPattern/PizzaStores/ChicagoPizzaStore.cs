using FactoryPattern.IngredientFactories;
using FactoryPattern.Pizzas;

namespace FactoryPattern.PizzaStores;

internal class ChicagoPizzaStore : PizzaStore
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public ChicagoPizzaStore()
    {
        _ingredientFactory = new ChicagoIngredientFactory();
    }

    internal override Pizza CreatePizza(PizzaType pizzaType) => pizzaType switch
    {
        PizzaType.Clam => new ClamPizza(_ingredientFactory, "Chicago Deep Dish Clam Pizza"),
        PizzaType.Peppperoni => new PepperoniPizza(_ingredientFactory, "Chicago Deep Dish Pepperoni Pizza"),
        PizzaType.Veggie => new VeggiePizza(_ingredientFactory, "Chicago Deep Dish Veggie Pizza"),
        PizzaType.Cheese => new CheesePizza(_ingredientFactory, "Chicago Deep Dish Cheese Pizza"),
        _ => throw new ArgumentException("Not a valid Chicago Pizza!")
    };
}
