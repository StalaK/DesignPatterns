namespace TemplatePattern;

internal class Tea : CaffeineBeverage
{
    internal override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }

    internal override void Brew()
    {
        Console.WriteLine("Steeping tea bag");
    }

    internal override bool CustomerWantsCondiments()
    {
        Console.Write("Do you want lemon with your tea? (Y/N): ");
        var answer = Console.ReadKey();
        Console.WriteLine();
        return answer.Key.ToString().Equals("Y", StringComparison.OrdinalIgnoreCase);
    }
}