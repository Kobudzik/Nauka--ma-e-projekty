using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
			// Create the Subject object
			// It will handle updating all observers 
			// as well as deleting and adding them
			StockGrabber stockGrabber = new StockGrabber();

			// Create an Observer that will be sent updates from Subject
			StockObserver observer1 = new StockObserver(stockGrabber);

			stockGrabber.SetIBMPrice(197.00);
			stockGrabber.SetAAPLPrice(677.60);
			stockGrabber.SetGOOGPrice(676.40);

			StockObserver observer2 = new StockObserver(stockGrabber);

			stockGrabber.SetIBMPrice(197.00);
			stockGrabber.SetAAPLPrice(677.60);
			stockGrabber.SetGOOGPrice(676.40);

			// Delete one of the observers
			// stockGrabber.unregister(observer2);

			stockGrabber.SetIBMPrice(197.00);
			stockGrabber.SetAAPLPrice(677.60);
			stockGrabber.SetGOOGPrice(676.40);


			Console.ReadKey();
        }
    }
}
