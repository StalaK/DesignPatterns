namespace StrategyPattern;

internal class KnifeBehavior : IWeaponBehavior
{
    void IWeaponBehavior.UseWeapon()
    {
        Console.WriteLine("<< stabs >>");
    }
}
