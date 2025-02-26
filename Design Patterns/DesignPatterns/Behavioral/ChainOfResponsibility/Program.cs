using ChainOfResponsibility.Chains;
using System;

namespace ChainOfResponsibility;

static class Program
{
    static void Main()
    {
        // Here I define all of the objects in the chain
        IChain chain1 = new AddNumbers();
        IChain chain2 = new SubtractNumbers();

        // Here I tell each object where to forward the
        // data if it can't process the request
        chain1.SetNextChain(chain2);

        // Define the data in the Numbers Object
        // and send it to the first Object in the chain
        chain1.Calculate(new CalculationRequest(4, 2, "add"));
        chain1.Calculate(new CalculationRequest(4, 2, "sub"));
        chain1.Calculate(new CalculationRequest(4, 2, "div"));

        Console.ReadKey();
    }
}
