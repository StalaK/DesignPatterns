using System.Threading.Channels;

namespace FacadePattern;

public class Projector
{
    private readonly DvdPlayer _dvdPlayer;

    public Projector(DvdPlayer dvdPlayer)
    {
        _dvdPlayer = dvdPlayer;
    }

    public void On()
    {
        Console.WriteLine("Projector on");
    }

    public void Off()
    {
        Console.WriteLine("Projector off");
    }

    public void TvMode()
    {
        Console.WriteLine("Projector on TV mode");
        _dvdPlayer.Off();
    }

    public void WidescreenMode()
    {
        Console.WriteLine("Projector in widescreen mode");
    }
}