namespace FacadePattern;

public class Amplifier
{
    private readonly Tuner _tuner;
    private readonly DvdPlayer _dvdPlayer;
    private readonly CdPlayer _cdPlayer;
    
    public Amplifier(Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer)
    {
        _tuner = tuner;
        _dvdPlayer = dvdPlayer;
        _cdPlayer = cdPlayer;
    }

    public void On()
    {
        Console.WriteLine("Amp On");
    }

    public void Off()
    {
        Console.WriteLine("Amp off");
    }

    public void SetCd()
    {
        _cdPlayer.On();
    }

    public void SetDvd()
    {
        _dvdPlayer.On();
    }

    public void SetStereoSound()
    {
        Console.WriteLine("Amp using stereo sound");
    }

    public void SetSurroundSound()
    {
        Console.WriteLine("Amp using surround sound");
    }

    public void SetTuner()
    {
        _tuner.On();
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Amp volume: {volume}");
    }
}