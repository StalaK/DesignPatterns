namespace StatePattern;

internal class WinnerState : IState
{
    private readonly GumballMachine _gumballMachine;
    public WinnerState(GumballMachine gumballMachine)
    {

        _gumballMachine = gumballMachine;
    }

    public void Dispense()
    {
        Console.WriteLine("YOU'RE A WINNER! You get two gumballs for your quarter");
        _gumballMachine.ReleaseBall();

        if (_gumballMachine.Count == 0)
        {
            _gumballMachine.SetState(_gumballMachine.SoldState);
        }
        else
        {
            _gumballMachine.ReleaseBall();

            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
            else
            {
                Console.WriteLine("Oops! Out of gumballs!");
                _gumballMachine.SetState(_gumballMachine.SoldState);
            }
        }
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice won't get you another gumball!");
    }
}