// Facade pattern provides a simple interface to functionality
// still exposes the original interface so it can be used where required 

using FacadePattern;

var radio = new Tuner();
var dvd = new DvdPlayer();
var cd = new CdPlayer();
var amp = new Amplifier(radio, dvd, cd);
var popcorn = new PopcornPopper();
var projector = new Projector(dvd);
var screen = new Screen();
var lights = new TheatreLights();

var homeTheatreRemote = new HomeTheatreFacacde(
    amp,
    cd,
    dvd,
    popcorn,
    projector,
    screen,
    lights,
    radio);
    
// The facade simplifies calling these functions so that they done have to be repeated every time a movie is watched
homeTheatreRemote.WatchMovie();
Thread.Sleep(1000);

// The original interfaces are still available if we need them
amp.SetVolume(7);

Thread.Sleep(1000);
homeTheatreRemote.EndMovie();
    