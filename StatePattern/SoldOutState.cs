namespace StatePattern;

internal class SoldOutState : IState
{
    private readonly GumballMachine _gumballMachine;

    public SoldOutState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Cannot eject, you haven't inserted a quarter yet!");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You cannot insert a quarter, the machine has sold out!");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there are no gumballs!");
    }
}