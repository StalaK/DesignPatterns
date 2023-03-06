using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

internal class CeilingFanOnFullCommand : ICommand
{
    private readonly CeilingFan _ceilingFan;
    private int _previousSpeed = -1;

    public CeilingFanOnFullCommand(CeilingFan celingFan)
    {
        _ceilingFan = celingFan;
    }

    void ICommand.Execute()
    {
        _previousSpeed = _ceilingFan.GetSpeed();

        if (_ceilingFan.GetSpeed() < 1)
            _ceilingFan.Low();

        if (_ceilingFan.GetSpeed() < 2)
            _ceilingFan.Medium();

        if (_ceilingFan.GetSpeed() < 3)
            _ceilingFan.High();
    }

    void ICommand.Undo()
    {
        _previousSpeed -= _ceilingFan.GetSpeed();

        if (_ceilingFan.GetSpeed() > _previousSpeed && _ceilingFan.GetSpeed() > 2)
            _ceilingFan.Medium();

        if (_ceilingFan.GetSpeed() > _previousSpeed && _ceilingFan.GetSpeed() > 1)
            _ceilingFan.Low();

        if (_ceilingFan.GetSpeed() > _previousSpeed && _ceilingFan.GetSpeed() > 0)
            _ceilingFan.Off();
    }
}