using SingletonPattern;

var boiler = ChocolateBoiler.GetInstance();

Console.WriteLine("Create");
Console.WriteLine($"Boiler - \t\tEmpty: {boiler.IsEmpty} Boiled: {boiler.IsBoiled}");

boiler.Fill();
Console.WriteLine("\nFill");
Console.WriteLine($"Boiler - \t\tEmpty: {boiler.IsEmpty} Boiled: {boiler.IsBoiled}");

// Same instance as "boiler" is returned here. Evidenced by the empty and boiled fields 
// containing the same value
var boilerAgain = ChocolateBoiler.GetInstance();

boiler.Boil();
Console.WriteLine("\nBoil");
Console.WriteLine($"Boiler - \t\tEmpty: {boiler.IsEmpty} Boiled: {boiler.IsBoiled}");
Console.WriteLine($"Boiler (again) - \tEmpty: {boilerAgain.IsEmpty} Boiled: {boilerAgain.IsBoiled}");

// Because both "boiler" and "boilerAgain" point to the same class instance, performing "drain" on
// one instance means using the other reference will return the same values
boiler.Drain();
Console.WriteLine("\nDrain");
Console.WriteLine($"Boiler - \t\tEmpty: {boiler.IsEmpty} Boiled: {boiler.IsBoiled}");
Console.WriteLine($"Empty (again) - \tEmpty: {boilerAgain.IsEmpty} Boiled: {boilerAgain.IsBoiled}");