using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

internal class HotTubOffCommand : ICommand
{
    private readonly HotTub _hotTub;

    public HotTubOffCommand(HotTub hotTub)
    {
        _hotTub = hotTub;
    }

    void ICommand.Execute()
    {
        _hotTub.JetsOff();
    }

    void ICommand.Undo()
    {
        _hotTub.JetsOn();
    }
}