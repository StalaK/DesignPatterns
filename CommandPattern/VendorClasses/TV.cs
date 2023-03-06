namespace CommandPattern.VendorClasses;

internal class TV
{
    private readonly string _name;

    public TV(string name = "")
    {
        _name = string.IsNullOrEmpty(name) ? "TV" : name;
    }

    internal void On()
    {
        Console.WriteLine($"{_name} turned on");
    }

    internal void Off()
    {
        Console.WriteLine($"{_name} turned off");
    }

    internal void SetChannel(int channel)
    {
        Console.WriteLine($"{_name} channel set to {channel}");
    }

    internal void SetVolume(int volume)
    {
        Console.WriteLine($"{_name} volume set to {volume}");
    }
}