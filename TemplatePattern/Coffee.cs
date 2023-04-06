namespace TemplatePattern;

internal class Coffee : CaffeineBeverage
{
    internal override void AddCondiments()
    {
        Console.WriteLine("Adding sugar and milk");
    }

    internal override void Brew()
    {
        Console.WriteLine("Brewing coffee grinds");
    }
}