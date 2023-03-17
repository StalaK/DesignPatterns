namespace FacadePattern;

public class DvdPlayer
{   
    public void On()
    {
        Console.WriteLine("DVD Player On");
    }

    public void Off()
    {
        Console.WriteLine("DVD Player off");
    }

    public void Eject()
    {
        Console.WriteLine("DVD ejected");
    }

    public void Pause()
    {
        Console.WriteLine("DVD paused");
    }

    public void Play(string movie)
    {
        Console.WriteLine($"DVD Playing: {movie}");
    }

    public void SetSurroundAudio()
    {
        Console.WriteLine("DVD set to surround sound");
    }

    public void SetTwoChannelAudio()
    {
        Console.WriteLine("DVD set to dual channel audio");
    }

    public void Stop()
    {
        Console.WriteLine("DVD Stopped");
    }
}