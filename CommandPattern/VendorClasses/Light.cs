namespace CommandPattern.VendorClasses;

internal class Light
{
    private readonly string _name;

    public Light(string name = "")
    {
        _name = string.IsNullOrEmpty(name) ? "Light" : name;
    }

    internal void On()
    {
        Console.WriteLine($"{_name} on");
    }

    internal void Off()
    {
        Console.WriteLine($"{_name} off");
    }
}