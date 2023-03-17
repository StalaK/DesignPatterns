// The adapter class "alters" an interface to one the client is expecting
using AdapterPattern;

IDuck duck = new MallardDuck();

Console.WriteLine("--- DUCK ---");
duck.Quack();
duck.Fly();

ITurkey turkey = new WildTurkey();

// we're expecting a duck so the adapter wraps the turkey in a duck interface so it can behave like a duck
IDuck adaptedTurkey = new TurkeyAdapter(turkey);

Console.WriteLine("--- ADAPTED TURKEY ---");
adaptedTurkey.Quack();
adaptedTurkey.Fly();
