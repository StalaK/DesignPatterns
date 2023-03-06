namespace CommandPattern;

// Command
internal interface ICommand
{
    internal void Execute();

    internal void Undo();
}
