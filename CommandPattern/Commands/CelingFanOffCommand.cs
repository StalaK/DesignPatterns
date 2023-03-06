using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

internal class CelingFanOffCommand : ICommand
{
    private readonly CeilingFan _ceilingFan;
    private int _previousSpeed = -1;

    public CelingFanOffCommand(CeilingFan celingFan)
    {
        _ceilingFan = celingFan;
    }

    void ICommand.Execute()
    {
        _previousSpeed = _ceilingFan.GetSpeed();

        if (_ceilingFan.GetSpeed() == 3)
            _ceilingFan.Medium();

        if (_ceilingFan.GetSpeed() == 2)
            _ceilingFan.Low();

        if (_ceilingFan.GetSpeed() == 1)
            _ceilingFan.Off();
    }

    void ICommand.Undo()
    {
        if (_ceilingFan.GetSpeed() < 1 && _ceilingFan.GetSpeed() != _previousSpeed)
            _ceilingFan.Low();

        if (_ceilingFan.GetSpeed() < 2 && _ceilingFan.GetSpeed() != _previousSpeed)
            _ceilingFan.Medium();

        if (_ceilingFan.GetSpeed() < 3 && _ceilingFan.GetSpeed() != _previousSpeed)
            _ceilingFan.High();
    }
}