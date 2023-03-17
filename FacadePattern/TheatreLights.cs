namespace FacadePattern;

public class TheatreLights
{
    public void On()
    {
        Console.WriteLine("Lights on");
    }
    
    public void Off()
    {
        Console.WriteLine("Lights off");
    }

    public void Dim(decimal percentage)
    {
        Console.WriteLine($"Lights dimmed to {percentage}%");
    }
}