namespace CompoundPatterns;

internal static class DuckSimulator
{
    internal static void Simulate(AbstractDuckFactory duckFactory)
    {
        Console.WriteLine("\n*** Duck Simulator: With Composite - Flocks" +
            " ***\n");

        // Decorate IQuackable with a QuackCounter
        IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
        IQuackable duckCall = duckFactory.CreateDuckCall();
        IQuackable rubberDuck = duckFactory.CreateRubberDuck();

        // Adapter pattern
        //IQuackable goose = new GooseAdapter(new Goose());
        IQuackable goose = duckFactory.CreateGooseDuck();

        var flockOfDucks = new Flock();
        flockOfDucks.Add(redheadDuck);
        flockOfDucks.Add(duckCall);
        flockOfDucks.Add(rubberDuck);
        flockOfDucks.Add(goose);

        var flockOfMallards = new Flock();
        var mallardOne = duckFactory.CreateMallardDuck();
        var mallardTwo = duckFactory.CreateMallardDuck();
        var mallardThree = duckFactory.CreateMallardDuck();
        var mallardFour = duckFactory.CreateMallardDuck();

        flockOfMallards.Add(mallardOne);
        flockOfMallards.Add(mallardTwo);
        flockOfMallards.Add(mallardThree);
        flockOfMallards.Add(mallardFour);

        flockOfDucks.Add(flockOfMallards);

        Console.WriteLine("\n*** Duck Simulator: Whole Flock ***\n");
        Simulate(flockOfDucks);

        Console.WriteLine("\n*** Duck Simulator: Mallard Flock - Flocks ***\n");
        Simulate(flockOfMallards);

        Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
    }

    internal static void SimulateWithObserver(AbstractDuckFactory duckFactory)
    {
        Console.WriteLine("\n*** Duck Simulator: With Observer ***\n");

        IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
        IQuackable duckCall = duckFactory.CreateDuckCall();
        IQuackable rubberDuck = duckFactory.CreateRubberDuck();
        IQuackable goose = duckFactory.CreateGooseDuck();

        var flockOfDucks = new Flock();
        flockOfDucks.Add(redheadDuck);
        flockOfDucks.Add(duckCall);
        flockOfDucks.Add(rubberDuck);
        flockOfDucks.Add(goose);

        var flockOfMallards = new Flock();
        var mallardOne = duckFactory.CreateMallardDuck();
        var mallardTwo = duckFactory.CreateMallardDuck();
        var mallardThree = duckFactory.CreateMallardDuck();
        var mallardFour = duckFactory.CreateMallardDuck();

        flockOfMallards.Add(mallardOne);
        flockOfMallards.Add(mallardTwo);
        flockOfMallards.Add(mallardThree);
        flockOfMallards.Add(mallardFour);

        flockOfDucks.Add(flockOfMallards);

        var quackologist = new Quackologist();
        flockOfDucks.RegisterObserver(quackologist);

        Simulate(flockOfDucks);

        Console.WriteLine($"\nThe ducks quacked {QuackCounter.NumberOfQuacks} times");
    }

    private static void Simulate(IQuackable duck) => duck.Quack();

}