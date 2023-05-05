namespace StatePattern;

internal class HasQuarterState : IState
{
    private readonly GumballMachine _gumballMachine;
    private readonly Random _randomWinner;

    public HasQuarterState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
        _randomWinner = new Random();
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter ejected");
        _gumballMachine.SetState(_gumballMachine.NoQuarterState);
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You cannot insert another quarter!");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned...");

        var winner = _randomWinner.Next(10);

        if (winner == 0 && _gumballMachine.Count > 1)
            _gumballMachine.SetState(_gumballMachine.WinnerState);
        else
            _gumballMachine.SetState(_gumballMachine.SoldState);
    }
}