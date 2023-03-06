// Decouples the requester of the action and the performer of the action

using CommandPattern;
using CommandPattern.Commands;
using CommandPattern.VendorClasses;

var remote = new RemoteControl();

var livingRoomLight = new Light("Living room light");
var kitchenLight = new Light("Kitchen light");
var ceilingFan = new CeilingFan();
var garageDoor = new GarageDoor();
var stereo = new Stereo();
var tv = new TV();
var hotTub = new HotTub();

var partyOn = new ICommand[]
{
    new LightOnCommand(livingRoomLight),
    new StereoOnWithCDCommand(stereo),
    new TvOnCommand(tv),
    new HotTubOnCommand(hotTub),
};

var partyOff = new ICommand[]
{
    new LightOffCommand(livingRoomLight),
    new StereoOffCommand(stereo),
    new TvOffCommand(tv),
    new HotTubOffCommand(hotTub),
};

remote.SetCommand(0, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));
remote.SetCommand(1, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
remote.SetCommand(2, new CeilingFanOnFullCommand(ceilingFan), new CelingFanOffCommand(ceilingFan));
remote.SetCommand(3, new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor));
remote.SetCommand(4, new StereoOnWithCDCommand(stereo), new StereoOffCommand(stereo));
remote.SetCommand(5, new MacroCommand(partyOn), new MacroCommand(partyOff));

//Console.ForegroundColor = ConsoleColor.DarkGreen;
//remote.OnButtonWasPushed(0);
//remote.OffButtonWasPushed(0);

//Console.ForegroundColor = ConsoleColor.DarkBlue;
//remote.OnButtonWasPushed(1);
//remote.OffButtonWasPushed(1);

//Console.ForegroundColor = ConsoleColor.DarkCyan;
//remote.OnButtonWasPushed(2);
//remote.OffButtonWasPushed(2);

//Console.ForegroundColor = ConsoleColor.DarkGray;
//remote.OnButtonWasPushed(3);
//remote.OffButtonWasPushed(3);

//Console.ForegroundColor = ConsoleColor.DarkMagenta;
//remote.OnButtonWasPushed(4);
//remote.OffButtonWasPushed(4);

Console.ForegroundColor = ConsoleColor.DarkRed;
remote.OnButtonWasPushed(5);
remote.OffButtonWasPushed(5);

Console.ForegroundColor = ConsoleColor.DarkYellow;
remote.OnButtonWasPushed(6);
remote.OffButtonWasPushed(6);

Console.ResetColor();