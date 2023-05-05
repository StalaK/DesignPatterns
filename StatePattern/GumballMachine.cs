namespace StatePattern;

internal class GumballMachine
{
    public IState SoldOutState { get; init; }
    public IState NoQuarterState { get; init; }
    public IState HasQuarterState { get; init; }
    public IState SoldState { get; init; }
    public IState WinnerState { get; init; }
    public int Count { get; private set; }

    private IState _state;

    public GumballMachine(int count)
    {
        SoldOutState = new SoldOutState(this);
        NoQuarterState = new NoQuarterState(this);
        HasQuarterState = new HasQuarterState(this);
        SoldState = new SoldState(this);
        WinnerState = new WinnerState(this);

        Count = count;

        _state = count > 0 ? NoQuarterState : SoldState;
    }

    public void InsertQuarter() => _state.InsertQuarter();
    public void EjectQuarter() => _state.EjectQuarter();
    public void TurnCrank()
    {
        _state.TurnCrank();
        _state.Dispense();
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot...");
        Count--;
    }
}