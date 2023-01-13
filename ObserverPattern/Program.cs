using ObserverPattern.BuiltInImplementation;
using ObserverPattern.ManualImplementation;

Console.WriteLine("==================================");
Console.WriteLine("\nMANUAL IMPLEMENTATION\n");
Console.WriteLine("==================================");

var weatherData = new ObserverPattern.ManualImplementation.WeatherData();

var currentDisplay = new CurrentConditionsDisplay(weatherData);
var statusDisplay = new ObserverPattern.ManualImplementation.StatisticsDisplay(weatherData);
var forecast = new ForecastDisplay(weatherData);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("READING MEASUREMENTS\n");
weatherData.SetMeasurements(80, 65, 30.4m);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("READING MEASUREMENTS\n");
weatherData.SetMeasurements(82, 70, 29.2m);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("READING MEASUREMENTS\n");
weatherData.SetMeasurements(78, 90, 29.2m);

Console.WriteLine("==================================");
Console.WriteLine("\nBUILT IN C# IMPLEMENTATION\n");
Console.WriteLine("==================================");

// https://learn.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern
var weatherData2 = new ObserverPattern.BuiltInImplementation.WeatherData();

// Example calling subscribe manually
var generalDisplay = new GeneralDisplay();
generalDisplay.Subscribe(weatherData2);

// Alternatively, you can pass the object in via ctor and subscribe in ctor
var statisticsDisplay = new ObserverPattern.BuiltInImplementation.StatisticsDisplay(weatherData2);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("READING MEASUREMENTS\n");
weatherData2.SetMeasurements(80, 65, 30.4m);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("READING MEASUREMENTS\n");
weatherData2.SetMeasurements(82, 70, 29.2m);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("READING MEASUREMENTS\n");
weatherData2.SetMeasurements(78, 90, 29.2m);