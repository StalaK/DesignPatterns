namespace TemplatePattern;

internal abstract class CaffeineBeverage
{
    /// <summary>
    /// The template order for which the steps are performed
    /// </summary>
    internal void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();

        if (CustomerWantsCondiments())
            AddCondiments();
    }

    /// <summary>
    /// Abstact functions are areas where each implementation can differ so must
    /// be implemented by it's derived type
    /// </summary>
    internal abstract void Brew();

    internal abstract void AddCondiments();

    /// <summary>
    /// Concrete functions are areas which remain the same across all implementations
    /// </summary>
    internal void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    internal void PourInCup()
    {
        Console.WriteLine("Pouring beverage into cup");
    }

    /// <summary>
    /// This is a hook. It allows the derived types to override if needed, but it
    /// doesn't have to.
    /// </summary>
    internal virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}