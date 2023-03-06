namespace CommandPattern;

// SimpleRemoteControl only has one command slot

// Client
internal class SimpleRemoteControl
{
    // Invoker
    internal ICommand Slot { get; set; }

    // Receiver
    internal void ButtonWasPressed()
    {
        Slot?.Execute();
    }
}