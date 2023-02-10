namespace FactoryPattern.Pizzas;

internal class ClamPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public ClamPizza(IPizzaIngredientFactory factory, string name)
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
        Clams = _ingredientFactory.CreateClams();

        Console.WriteLine($"Ingredients: {Dough.GetType().Name}, {Sauce.GetType().Name}, {Cheese.GetType().Name}, {Clams.GetType().Name}");
    }
}
