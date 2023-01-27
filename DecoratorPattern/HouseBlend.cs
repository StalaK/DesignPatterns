namespace DecoratorPattern;

internal class HouseBlend : IBeverage
{
    public decimal Cost() => 0.89m;

    public string GetDescription() => "House Blend";
}
