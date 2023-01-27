namespace DecoratorPattern;

internal class Espresso : IBeverage
{
    public decimal Cost() => 1.99m;

    public string GetDescription() => "Espresso";
}
