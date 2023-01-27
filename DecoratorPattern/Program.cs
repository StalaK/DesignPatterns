using DecoratorPattern;

// Following the book, you can decorate a concrete class like so:
IBeverage drink1 = new DarkRoast();
drink1 = new Soy(drink1);
drink1 = new Whip(drink1);

Console.WriteLine($"Drink 1: {drink1.GetDescription()} - Cost: {drink1.Cost()}");

// This, however, can lead to code like this which is hard to follow because you read it inside out
IBeverage drink2 = new SteamedMilk(new Soy(new Whip(new Decaf())));
Console.WriteLine($"Drink 2: {drink2.GetDescription()} - Cost: {drink2.Cost()}");

// We can use extension methods to tidy this up and make it fluent
var drink3 = new Espresso()
    .AddSoy()
    .AddMocha()
    .AddSteamedMilk()
    .AddWhip();

Console.WriteLine($"Drink 3: {drink3.GetDescription()} - Cost: {drink3.Cost()}");
