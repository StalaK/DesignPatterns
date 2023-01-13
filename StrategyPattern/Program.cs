using StrategyPattern;

Console.WriteLine("Hello, World!");

Character a = new King();
a.SetWeapon(new KnifeBehavior());

a.Fight();