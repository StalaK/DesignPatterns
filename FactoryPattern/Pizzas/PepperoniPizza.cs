namespace FactoryPattern.Pizzas;

internal class PepperoniPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public PepperoniPizza(IPizzaIngredientFactory factory, string name)
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
        Pepperoni = _ingredientFactory.CreatePepperoni();

        Console.WriteLine($"Ingredients: {Dough.GetType().Name}, {Sauce.GetType().Name}, {Cheese.GetType().Name}, {Pepperoni.GetType().Name}");
    }
}
