namespace CommandPattern.VendorClasses;

internal class Stereo
{
    private readonly string _name;

    public Stereo(string name = "")
    {
        _name = string.IsNullOrEmpty(name) ? "Stereo" : name;
    }

    internal void On()
    {
        Console.WriteLine($"{_name} on");
    }

    internal void Off()
    {
        Console.WriteLine($"{_name} off");
    }

    internal void SetCD()
    {
        Console.WriteLine($"{_name} CD Set");
    }

    internal void SetDVD()
    {
        Console.WriteLine($"{_name} DVD set");
    }

    internal void SetRadio()
    {
        Console.WriteLine($"{_name} radio set");
    }

    internal void SetVolume(int volume)
    {
        Console.WriteLine($"{_name} volume set to {volume}");
    }
}