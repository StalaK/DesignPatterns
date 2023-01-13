namespace StrategyPattern;

internal class Character
{
    IWeaponBehavior _weapon;

    internal void Fight()
    {
        _weapon.UseWeapon();
    }

    internal void SetWeapon(IWeaponBehavior weapon)
    {
        _weapon = weapon;
    }
}
