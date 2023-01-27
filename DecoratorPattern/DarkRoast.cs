namespace DecoratorPattern;

internal class DarkRoast : IBeverage
{
    public decimal Cost() => 0.99m;

    public string GetDescription() => "Dark Roast";
}
