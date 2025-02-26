using Observer.Observers;
using Observer.Subjects;
using System;

namespace Observer;

static class Program
{
    static void Main()
    {
        StockGrabber stockGrabber = new();
        StockObserver observer1 = new(stockGrabber);

        stockGrabber.SetIBMPrice(197.00);
        stockGrabber.SetAAPLPrice(677.60);
        stockGrabber.SetGOOGPrice(676.40);

        StockObserver observer2 = new(stockGrabber);

        stockGrabber.SetIBMPrice(197.00);
        stockGrabber.SetAAPLPrice(677.60);
        stockGrabber.SetGOOGPrice(676.40);

        // Delete one of the observers
        stockGrabber.Unregister(observer2);

        stockGrabber.SetIBMPrice(197.00);
        stockGrabber.SetAAPLPrice(677.60);
        stockGrabber.SetGOOGPrice(676.40);

        Console.ReadKey();
    }
}
