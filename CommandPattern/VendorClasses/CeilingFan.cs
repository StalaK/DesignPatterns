namespace CommandPattern.VendorClasses;

internal class CeilingFan
{
    private int _speed = 0;

    private string _name;

    public CeilingFan(string name = "")
    {
        _name = string.IsNullOrEmpty(name) ? "Ceiling Fan" : name;
    }

    internal void High()
    {
        _speed = 3;
        Console.WriteLine($"{_name} speed high");
    }

    internal void Medium()
    {
        _speed = 2;
        Console.WriteLine($"{_name} speed medium");
    }

    internal void Low()
    {
        _speed = 1;
        Console.WriteLine($"{_name} speed low");
    }

    internal void Off()
    {
        _speed = 0;
        Console.WriteLine($"{_name} off");
    }

    internal int GetSpeed()
    {
        return _speed;
    }
}