using Observer.Observers;
using System;
using System.Collections.Generic;

namespace Observer.Subjects;

public class StockGrabber : ISubject
{
    private readonly List<IObserver> observers = [];
    private double ibmPrice;
    private double applePrice;
    private double googlePrice;

    public void Register(IObserver newObserver)
    {
        observers.Add(newObserver);
    }

    public void Unregister(IObserver deleteObserver)
    {
        Console.WriteLine("Observer " + (observers.IndexOf(deleteObserver) + 1) + " deleted");
        observers.Remove(deleteObserver);
    }

    public void NotifyObserver()
    {
        foreach (IObserver ob in observers)
            ob.Update(ibmPrice, applePrice, googlePrice);
    }

    public void SetIBMPrice(double newIBMPrice)
    {
        ibmPrice = newIBMPrice;
        NotifyObserver();
    }

    public void SetAAPLPrice(double newAAPLPrice)
    {
        applePrice = newAAPLPrice;
        NotifyObserver();
    }

    public void SetGOOGPrice(double newGOOGPrice)
    {
        googlePrice = newGOOGPrice;
        NotifyObserver();
    }
}
