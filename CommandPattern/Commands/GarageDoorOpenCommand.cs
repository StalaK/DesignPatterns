using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

internal class GarageDoorOpenCommand : ICommand
{
    private readonly GarageDoor _garageDoor;

    public GarageDoorOpenCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    void ICommand.Execute()
    {
        _garageDoor.Up();
        _garageDoor.LightOn();
    }

    void ICommand.Undo()
    {
        _garageDoor.Stop();
        _garageDoor.LightOff();
        _garageDoor.Down();
    }
}