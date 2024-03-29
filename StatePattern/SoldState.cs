﻿namespace StatePattern;

internal class SoldState : IState
{
    private readonly GumballMachine _gumballMachine;

    public SoldState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense()
    {
        _gumballMachine.ReleaseBall();
        if (_gumballMachine.Count > 0)
        {
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }
        else
        {
            Console.WriteLine("Oops, out of gumballs!");
            _gumballMachine.SetState(_gumballMachine.SoldOutState);
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