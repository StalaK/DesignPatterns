using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

// Concrete command
internal class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    void ICommand.Execute()
    {
        _light.On();
    }

    void ICommand.Undo()
    {
        _light.Off();
    }
}
