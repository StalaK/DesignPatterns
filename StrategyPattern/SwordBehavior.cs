namespace StrategyPattern;

internal class SwordBehavior : IWeaponBehavior
{
    void IWeaponBehavior.UseWeapon()
    {
        Console.WriteLine("<< slashes >>");
    }
}
