namespace StrategyPattern;

internal class AxeBehavior : IWeaponBehavior
{
    void IWeaponBehavior.UseWeapon()
    {
        Console.WriteLine("<< chops >>");
    }
}
