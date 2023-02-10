using FactoryPattern.Ingredients.Base;

namespace FactoryPattern;

internal interface IPizzaIngredientFactory
{
    IDough CreateDough();
    ISauce CreateSauce();
    ICheese CreateCheese();
    List<IVeg> CreateVeg();
    IPepperoni CreatePepperoni();
    IClams CreateClams();
}
