using CompoundPatterns;

// Start with quackables
// Goose wants to act like a quackable (adapter pattern)
// Quackologist wants to count quacks (abstract factory pattern)
// Management wants to keep track of quackables (composite pattern)
// Quackologists want to be notified of quacks (observer pattern)

var duckFactory = new CountingDuckFactory();
//DuckSimulator.Simulate(duckFactory);
DuckSimulator.SimulateWithObserver(duckFactory);