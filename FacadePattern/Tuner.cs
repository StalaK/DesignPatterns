namespace FacadePattern;

public class Tuner
{
    public Amplifier Amplifier { get; set; }

    public Tuner()
    {
    }

    public void On()
    {
        Console.WriteLine("Tuner on");
    }

    public void Off()
    {
        Console.WriteLine("Tuner off");
    }

    public void SetAm()
    {
        Console.WriteLine("Tuner set to AM band");
    }

    public void SetFm()
    {
        Console.WriteLine("Tuner set to FM band");
    }

    public void SetFrequency(decimal frequency)
    {
        Console.WriteLine($"Tuner frequency: {frequency}");
    }
}