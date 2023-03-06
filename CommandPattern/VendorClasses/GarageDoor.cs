namespace CommandPattern.VendorClasses;

internal class GarageDoor
{
    private readonly string _name;

    public GarageDoor(string name = "")
    {
        _name = string.IsNullOrEmpty(name) ? "Garage Door" : name;
    }

    internal void Up()
    {
        Console.WriteLine($"{_name} up");
    }

    internal void Down()
    {
        Console.WriteLine($"{_name} down");
    }

    internal void Stop()
    {
        Console.WriteLine($"{_name} stopped");
    }

    internal void LightOn()
    {
        Console.WriteLine($"{_name} light on");
    }

    internal void LightOff()
    {
        Console.WriteLine($"{_name} light off");
    }
}