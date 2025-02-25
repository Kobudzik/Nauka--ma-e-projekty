using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class StockGrabber : ISubject
    {
        private readonly List<IObserver> observers;
        private double ibmPrice;
        private double aaplPrice;
        private double googPrice;

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
            Console.WriteLine("Observer " + ((int)(observers.IndexOf(deleteObserver)) + 1) + " deleted");

            // Removes observer from the ArrayList
            observers.Remove(deleteObserver);
        }

        public void NotifyObserver()
        {
            // Cycle through all observers and notifies them of
            // price changes
            foreach (IObserver ob in observers)
                ob.Update(ibmPrice, aaplPrice, googPrice);
        }

        // Change prices for all stocks and notifies observers of changes
        public void SetIBMPrice(double newIBMPrice)
        {
            this.ibmPrice = newIBMPrice;
            NotifyObserver();
        }

        public void SetAAPLPrice(double newAAPLPrice)
        {
            this.aaplPrice = newAAPLPrice;
            NotifyObserver();
        }

        public void SetGOOGPrice(double newGOOGPrice)
        {
            this.googPrice = newGOOGPrice;
            NotifyObserver();
        }
    }
}
