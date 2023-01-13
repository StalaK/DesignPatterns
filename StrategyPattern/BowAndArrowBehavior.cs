namespace StrategyPattern;

internal class BowAndArrowBehavior : IWeaponBehavior
{
    void IWeaponBehavior.UseWeapon()
    {
        Console.WriteLine("<< shoots >>");
    }
}
