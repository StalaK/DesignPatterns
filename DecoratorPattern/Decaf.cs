namespace DecoratorPattern;

internal class Decaf : IBeverage
{
    public decimal Cost() => 1.05m;

    public string GetDescription() => "Decaf";
}
