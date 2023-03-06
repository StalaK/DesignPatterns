using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

internal class StereoOnWithCDCommand : ICommand
{
    private Stereo _stereo;

    public StereoOnWithCDCommand(Stereo stereo)
    {
        _stereo = stereo;
    }

    void ICommand.Execute()
    {
        _stereo.On();
        _stereo.SetCD();
        _stereo.SetVolume(11);
    }

    void ICommand.Undo()
    {
        _stereo.Off();
    }
}