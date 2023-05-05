using StatePattern;

// Thes state pattern allows an object to alter its behaviour when its internal state changes
// The object will appear to change its class

var gumballMachine = new GumballMachine(20);

gumballMachine.InsertQuarter();
gumballMachine.EjectQuarter();

while (gumballMachine.Count > 0)
{
    Console.WriteLine("---");
    gumballMachine.InsertQuarter();
    gumballMachine.TurnCrank();
}

Console.WriteLine("---");
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();