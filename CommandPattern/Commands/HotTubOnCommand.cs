using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

internal class HotTubOnCommand : ICommand
{
    private readonly HotTub _hotTub;

    public HotTubOnCommand(HotTub hotTub)
    {
        _hotTub = hotTub;
    }

    void ICommand.Execute()
    {
        _hotTub.SetTemperature(33);
        _hotTub.JetsOn();
        _hotTub.Circulate();
    }

    void ICommand.Undo()
    {
        _hotTub.JetsOff();
    }
}