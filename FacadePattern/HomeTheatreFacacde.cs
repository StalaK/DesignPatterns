namespace FacadePattern;

public class HomeTheatreFacacde
{
    private readonly Amplifier _amplifier;
    private readonly CdPlayer _cdPlayer;
    private readonly DvdPlayer _dvdPlayer;
    private readonly PopcornPopper _popcornPopper;
    private readonly Projector _projector;
    private readonly Screen _screen;
    private readonly TheatreLights _lights;
    private readonly Tuner _radio;

    public HomeTheatreFacacde(
        Amplifier amplifier,
        CdPlayer cdPlayer,
        DvdPlayer dvdPlayer,
        PopcornPopper popcornPopper,
        Projector projector,
        Screen screen,
        TheatreLights theatreLights,
        Tuner tuner)
    {
        _amplifier = amplifier;
        _cdPlayer = cdPlayer;
        _dvdPlayer = dvdPlayer;
        _popcornPopper = popcornPopper;
        _projector = projector;
        _screen = screen;
        _lights = theatreLights;
        _radio = tuner;
    }
    
    public void WatchMovie()
    {
        Console.WriteLine("--- WATCH MOVIE --");
        _popcornPopper.On();
        _popcornPopper.Pop();
        
        _lights.Dim(10);
        
        _screen.Down();
        
        _projector.On();
        _projector.WidescreenMode();
        
        _amplifier.On();
        _amplifier.SetDvd();
        _amplifier.SetSurroundSound();
        _amplifier.SetVolume(5);
        
        _dvdPlayer.On();
        _dvdPlayer.Play("Shawn Of The Dead");
        
    }

    public void EndMovie()
    {
        Console.WriteLine("--- MOVIE FINISHED ---");
        _popcornPopper.Off();
        _lights.On();
        _screen.Up();
        _projector.Off();
        _amplifier.Off();
        _dvdPlayer.Stop();
        _dvdPlayer.Eject();
        _dvdPlayer.Off();
    }

    public void ListenToCd()
    {
        Console.WriteLine("--- CD PLAYING ---");
    }

    public void EndCd()
    {
        Console.WriteLine("--- CD FINISHED ---");
    }

    public void ListenToRadio()
    {
        Console.WriteLine("--- RADIO PLAYING ---");
    }

    public void EndRadio()
    {
        Console.WriteLine("--- RADIO FINISHED ---");
    }
}