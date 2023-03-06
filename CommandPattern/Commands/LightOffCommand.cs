using CommandPattern.VendorClasses;

namespace CommandPattern.Commands;

// Concrete command
internal class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }

    void ICommand.Execute()
    {
        _light.Off();
    }

    void ICommand.Undo()
    {
        _light.On();
    }
}
