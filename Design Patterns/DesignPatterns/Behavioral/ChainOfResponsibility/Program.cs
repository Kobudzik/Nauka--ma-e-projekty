using System;

namespace DesignPatterns.ChainOfResponsibility
{
    static class Program
    {
        static void Main()
        {
            // Here I define all of the objects in the chain
            IChain chainCalc1 = new AddNumbers();
            IChain chainCalc2 = new SubtractNumbers();

            // Here I tell each object where to forward the
            // data if it can't process the request
            chainCalc1.SetNextChain(chainCalc2);

            // Define the data in the Numbers Object
            // and send it to the first Object in the chain
            Numbers request = new(4, 2, "add");
            chainCalc1.Calculate(request);

            request = new Numbers(4, 2, "sub");
            chainCalc1.Calculate(request);

            request = new Numbers(4, 2, "div");
            chainCalc1.Calculate(request);

            Console.ReadKey();
        }
    }
}
