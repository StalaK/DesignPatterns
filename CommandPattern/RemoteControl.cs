using CommandPattern.Commands;
using System.Text;

namespace CommandPattern;

internal class RemoteControl
{
    internal ICommand[] _onCommands;
    internal ICommand[] _offCommands;
    internal ICommand _undoCommand;

    internal RemoteControl()
    {
        _onCommands = new ICommand[7];
        _offCommands = new ICommand[7];

        var noCommand = new NoCommand();
        for (int i = 0; i < 7; i++)
        {
            _onCommands[i] = noCommand;
            _offCommands[i] = noCommand;
        }
    }

    internal void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    internal void OnButtonWasPushed(int slot)
    {
        _onCommands[slot].Execute();
        _undoCommand = _onCommands[slot];
    }

    internal void OffButtonWasPushed(int slot)
    {
        _offCommands[slot].Execute();
        _undoCommand = _offCommands[slot];
    }

    internal void UndoButtonWasPushed() => _undoCommand.Undo();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("\n----- Remote Control -----\n");

        for (int i = 0; i < 7; i++)
            sb.AppendLine($"[Slot {i}] {_onCommands[i].GetType().Name} {_offCommands[i].GetType().Name}");

        sb.AppendLine($"[Undo] {_undoCommand.GetType().Name}");

        return sb.ToString();
    }
}