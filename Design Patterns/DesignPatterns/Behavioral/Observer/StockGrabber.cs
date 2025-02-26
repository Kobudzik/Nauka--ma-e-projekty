using System;
using System.Collections.Generic;

namespace Observer;

public class StockGrabber : ISubject
{
    private readonly List<IObserver> observers;
    private double ibmPrice;
    private double applePrice;
    private double googlePrice;

    public StockGrabber()
    {
        // Creates an ArrayList to hold all observers
        observers = new List<IObserver>();
    }

    public void Register(IObserver newObserver)
    {
        // Adds a new observer to the ArrayList
        observers.Add(newObserver);
    }

    public void Unregister(IObserver deleteObserver)
    {
        // Print out message (Have to increment index to match)
        Console.WriteLine("Observer " + (observers.IndexOf(deleteObserver) + 1) + " deleted");

        // Removes observer from the ArrayList
        observers.Remove(deleteObserver);
    }

    public void NotifyObserver()
    {
        // Cycle through all observers and notifies them of
        // price changes
        foreach (IObserver ob in observers)
            ob.Update(ibmPrice, applePrice, googlePrice);
    }

    // Change prices for all stocks and notifies observers of changes
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
