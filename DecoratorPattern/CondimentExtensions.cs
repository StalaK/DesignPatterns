namespace DecoratorPattern;

internal static class CondimentExtensions
{
    public static IBeverage AddSoy(this IBeverage beverage) => new Soy(beverage);

    public static IBeverage AddWhip(this IBeverage beverage) => new Whip(beverage);

    public static IBeverage AddSteamedMilk(this IBeverage beverage) => new SteamedMilk(beverage);

    public static IBeverage AddMocha(this IBeverage beverage) => new Mocha(beverage);
}
