namespace DecoratorPattern;

internal class Mocha : ICondimentDecorator
{
    private readonly IBeverage _beverage;

    public Mocha(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public decimal Cost() => _beverage.Cost() + 0.20m;

    public string GetDescription() => _beverage.GetDescription() + ", Mocha";
}
