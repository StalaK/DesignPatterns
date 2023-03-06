namespace CommandPattern.Commands;

internal class NoCommand : ICommand
{
    void ICommand.Execute()
    {
        Console.WriteLine("No command set for this button");
    }

    void ICommand.Undo()
    {
        Console.WriteLine("No command set for this button");
    }
}