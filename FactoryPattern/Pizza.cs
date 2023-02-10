using FactoryPattern.Ingredients.Base;

namespace FactoryPattern;

internal abstract class Pizza
{
    public string Name { get; set; }
    public IDough Dough { get; set; }
    public ISauce Sauce { get; set; }
    public List<IVeg> Veg { get; set; }
    public ICheese Cheese { get; set; }
    public IPepperoni Pepperoni { get; set; }
    public IClams Clams { get; set; }

    internal abstract void Prepare();

    internal void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    internal void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    internal void Box()
    {
        Console.WriteLine("Place pizza into official PizzaStore box");
    }
}
