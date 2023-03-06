using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

internal class GarageDoorCloseCommand : ICommand
{
    private readonly GarageDoor _garageDoor;

    public GarageDoorCloseCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    void ICommand.Execute()
    {
        _garageDoor.LightOff();
        _garageDoor.Down();
    }

    void ICommand.Undo()
    {
        _garageDoor.Stop();
        _garageDoor.Up();
        _garageDoor.LightOn();
    }
}