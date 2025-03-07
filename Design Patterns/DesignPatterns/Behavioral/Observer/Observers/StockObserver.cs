﻿using Observer.Subjects;
using System;

namespace Observer.Observers;

public class StockObserver : IObserver
{
    private double ibmPrice;
    private double applePrice;
    private double googlePrice;

    // Static used as a counter
    private static int observerIDTracker = 0;

    // Used to track the observers
    private readonly int observerID;

    // Will hold reference to the StockGrabber object
    private readonly ISubject stockGrabber;

    public StockObserver(ISubject stockGrabber)
    {
        // Store the reference to the stockGrabber object so
        // I can make calls to its methods
        this.stockGrabber = stockGrabber;

        // Assign an observer ID and increment the static counter
        observerID = ++observerIDTracker;

        // Message notifies user of new observer
        Console.Write("New Observer " + observerID);

        // Add the observer to the Subjects ArrayList
        stockGrabber.Register(this);
    }

    // Called to update all observers
    public void Update(double ibmPrice, double applePrice, double googlePrice)
    {
        this.ibmPrice = ibmPrice;
        this.applePrice = applePrice;
        this.googlePrice = googlePrice;

        PrintThePrices();
    }

    public void PrintThePrices()
    {
        Console.Write(
            observerID + "\nIBM: " + ibmPrice + "\nAAPL: " + applePrice + "\nGOOG: " + googlePrice + "\n"
        );
    }
}
