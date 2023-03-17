namespace FacadePattern;

public class CdPlayer
{
    public void On()
    {
        Console.WriteLine("CD Player on");
    }

    public void Off()
    {
        Console.WriteLine("CD Player off");
    }

    public void Eject()
    {
        Console.WriteLine("CD ejected");
    }

    public void Play()
    {
        Console.WriteLine("Playing CD");
    }

    public void Pause()
    {
        Console.WriteLine("CD paused");
    }

    public void Stop()
    {
        Console.WriteLine("CD stopped");
    }
}