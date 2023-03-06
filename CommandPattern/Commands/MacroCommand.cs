namespace CommandPattern.Commands;

internal class MacroCommand : ICommand
{
    private readonly ICommand[] _commands;

    public MacroCommand(ICommand[] commands)
    {
        _commands = commands;
    }

    void ICommand.Execute()
    {
        for (int i = 0; i < _commands.Length; i++)
            _commands[i].Execute();
    }

    void ICommand.Undo()
    {
        for (int i = _commands.Length - 1; i >= 0; i--)
            _commands[i].Undo();
    }
}