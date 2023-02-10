using FactoryPattern.Ingredients;
using FactoryPattern.Ingredients.Base;

namespace FactoryPattern.IngredientFactories;

internal class NYIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese() => new ReggianoCheese();

    public IClams CreateClams() => new FreshClams();

    public IDough CreateDough() => new ThinCrustDough();

    public IPepperoni CreatePepperoni() => new SlicedPepperoni();

    public ISauce CreateSauce() => new MarinaraSauce();

    public List<IVeg> CreateVeg() => new()
    {
        new Garlic(),
        new Onion(),
        new Mushroom(),
        new RedPepper()
    };
}
