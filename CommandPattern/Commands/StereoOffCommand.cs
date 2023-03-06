using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

// Concrete command
internal class StereoOffCommand : ICommand
{
    private readonly Stereo _stereo;

    public StereoOffCommand(Stereo stereo)
    {
        _stereo = stereo;
    }

    void ICommand.Execute()
    {
        _stereo.Off();
    }

    void ICommand.Undo()
    {
        _stereo.On();
        _stereo.SetCD();
        _stereo.SetVolume(11);
    }
}
