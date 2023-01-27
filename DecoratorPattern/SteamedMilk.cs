namespace DecoratorPattern;

internal class SteamedMilk : ICondimentDecorator
{
    private readonly IBeverage _beverage;

    public SteamedMilk(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public decimal Cost() => _beverage.Cost() + 0.1m;

    public string GetDescription() => _beverage.GetDescription() + ", Steamed Milk";
}
