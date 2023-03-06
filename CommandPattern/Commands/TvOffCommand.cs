using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

internal class TvOffCommand : ICommand
{
    private readonly TV _tv;

    public TvOffCommand(TV tv)
    {
        _tv = tv;
    }

    void ICommand.Execute()
    {
        _tv.Off();
    }

    void ICommand.Undo()
    {
        _tv.On();
    }
}