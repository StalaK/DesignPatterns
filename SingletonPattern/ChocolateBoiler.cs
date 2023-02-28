using System.Runtime.CompilerServices;

namespace SingletonPattern;

internal class ChocolateBoiler
{
    private static ChocolateBoiler _instance = null!;

    // Can eagerly create an instance of Chocolate Boiler to remove the
    // requirement of a synchronized GetInstance function
    //private static ChocolateBoiler _instance = new();

    private bool _empty;
    private bool _boiled;

    private ChocolateBoiler()
    {
        _empty = true;
        _boiled = false;
    }

    // Add thread safety.https://stackoverflow.com/a/541348
    [MethodImpl(MethodImplOptions.Synchronized)]
    internal static ChocolateBoiler GetInstance()
    {
        _instance ??= new ChocolateBoiler();
        return _instance;
    }

    // Another performance improvement on the memory safety initialisation  is to
    // use "double checked locking" - _instance will need declaring as volatile as 
    // it could be modified by multiple threads
    //
    //private volatile static ChocolateBoiler _instance = null!;
    //private static object _lock = new();
    //internal static ChocolateBoiler GetInstance()
    //{
    //    if (_instance is null)
    //    {
    //        lock (_lock)
    //        {
    //            _instance ??= new ChocolateBoiler();
    //        }
    //    }

    //    return _instance;
    //}

    public void Fill()
    {
        if (IsEmpty)
        {
            _empty = false;
            _boiled = false;
        }
    }

    public void Drain()
    {
        if (!IsEmpty && IsBoiled)
        {
            _empty = true;
        }
    }

    public void Boil()
    {
        if (!IsEmpty && !IsBoiled)
        {
            _boiled = true;
        }
    }

    public bool IsEmpty => _empty;
    public bool IsBoiled => _boiled;
}