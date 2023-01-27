namespace DecoratorPattern;

internal class Soy : ICondimentDecorator
{
    private readonly IBeverage _beverage;

    public Soy(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public decimal Cost() => _beverage.Cost() + 0.15m;

    public string GetDescription() => _beverage.GetDescription() + ", Soy";
}
