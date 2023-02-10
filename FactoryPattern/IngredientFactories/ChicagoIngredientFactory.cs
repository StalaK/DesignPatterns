using FactoryPattern.Ingredients;
using FactoryPattern.Ingredients.Base;

namespace FactoryPattern.IngredientFactories;

internal class ChicagoIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese() => new Mozzarella();

    public IClams CreateClams() => new FrozenClams();

    public IDough CreateDough() => new ThickCrustDough();

    public IPepperoni CreatePepperoni() => new SlicedPepperoni();

    public ISauce CreateSauce() => new PlumTomatoSauce();

    public List<IVeg> CreateVeg() => new List<IVeg>
    {
        new Spinach(),
        new BlackOlives(),
        new Eggplant(),
    };
}
