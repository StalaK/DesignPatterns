using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

internal class TvOnCommand : ICommand
{
    private readonly TV _tv;

    public TvOnCommand(TV tv)
    {
        _tv = tv;
    }

    void ICommand.Execute()
    {
        _tv.On();
        _tv.SetChannel(1);
        _tv.SetVolume(10);
    }

    void ICommand.Undo()
    {
        _tv.Off();
    }
}