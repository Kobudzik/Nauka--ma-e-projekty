using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Observer
{
	public class StockObserver: Observer
	{


	private double ibmPrice;
	private double aaplPrice;
	private double googPrice;

	// Static used as a counter
	private static int observerIDTracker = 0;

	// Used to track the observers
	private int observerID;

	// Will hold reference to the StockGrabber object
	private Subject stockGrabber;

	public StockObserver(Subject stockGrabber)
	{

		// Store the reference to the stockGrabber object so
		// I can make calls to its methods
		this.stockGrabber = stockGrabber;

		// Assign an observer ID and increment the static counter
		this.observerID = ++observerIDTracker;

		// Message notifies user of new observer
		Console.Write("New Observer " + this.observerID);

		// Add the observer to the Subjects ArrayList
		stockGrabber.Register(this);

	}

	// Called to update all observers
	public void Update(double ibmPrice, double aaplPrice, double googPrice)
	{

		this.ibmPrice = ibmPrice;
		this.aaplPrice = aaplPrice;
		this.googPrice = googPrice;

		PrintThePrices();

	}

	public void PrintThePrices()
	{

		Console.Write(observerID + "\nIBM: " + ibmPrice + "\nAAPL: " +
				aaplPrice + "\nGOOG: " + googPrice + "\n");

	}

}
}
