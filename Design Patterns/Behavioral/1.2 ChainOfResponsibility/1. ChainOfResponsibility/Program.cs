using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
			// Here I define all of the objects in the chain
			Chain chainCalc1 = new AddNumbers();
			Chain chainCalc2 = new SubtractNumbers();


			// Here I tell each object where to forward the
			// data if it can't process the request
			chainCalc1.setNextChain(chainCalc2);


			// Define the data in the Numbers Object
			// and send it to the first Object in the chain
			Numbers request = new Numbers(4, 2, "add");
			chainCalc1.calculate(request);

			request = new Numbers(4, 2, "sub");
			chainCalc1.calculate(request);

			request = new Numbers(4, 2, "div");
			chainCalc1.calculate(request);

			Console.ReadKey();
		}
    }
}
