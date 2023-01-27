namespace DecoratorPattern;

internal class Whip : ICondimentDecorator
{
    private readonly IBeverage _beverage;

    public Whip(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public decimal Cost() => _beverage.Cost() + 0.15m;

    public string GetDescription() => _beverage.GetDescription() + ", Whip";
}
