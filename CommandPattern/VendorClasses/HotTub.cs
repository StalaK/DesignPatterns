namespace CommandPattern.VendorClasses;

internal class HotTub
{
    private readonly string _name;

    internal HotTub(string name = "")
    {
        _name = string.IsNullOrEmpty(name) ? "Hot tub" : name;
    }

    internal void Circulate()
    {
        Console.WriteLine($"{_name} circulating");
    }

    internal void JetsOn()
    {
        Console.WriteLine($"{_name} jets on");
    }

    internal void JetsOff()
    {
        Console.WriteLine($"{_name} jets off");
    }

    internal void SetTemperature(int temp)
    {
        Console.WriteLine($"{_name} temperature set to {temp}");
    }
}