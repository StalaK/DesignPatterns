﻿namespace StatePattern;

internal class NoQuarterState : IState
{
    private readonly GumballMachine _gumballMachine;

    public NoQuarterState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }
    public void Dispense()
    {
        Console.WriteLine("You need to pay first");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Cannot eject, you haven't inserted a quarter yet!");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        _gumballMachine.SetState(_gumballMachine.HasQuarterState);
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there is no quarter!");
    }
}