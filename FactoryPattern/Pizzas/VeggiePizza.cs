namespace FactoryPattern.Pizzas;

internal class VeggiePizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public VeggiePizza(IPizzaIngredientFactory factory, string name)
    {
        _ingredientFactory = factory;
        Name = name;
    }

    internal override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");

        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Veg = _ingredientFactory.CreateVeg();

        Console.WriteLine($"Ingredients: {Dough.GetType().Name}, {Sauce.GetType().Name}, {Cheese.GetType().Name}, {string.Join(", ", Veg.Select(x => x.GetType().Name))}");
    }
}
