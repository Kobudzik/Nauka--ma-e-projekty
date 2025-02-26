using System;

namespace ChainOfResponsibility;

internal class AddNumbers : IChain
{
    private IChain nextInChain;

    // Defines the next Object to receive the
    // data if this one can't use it
    public void SetNextChain(IChain nextChain)
    {
        nextInChain = nextChain;
    }

    // Tries to calculate the data, or passes it
    // to the Object defined in method setNextChain()
    public void Calculate(Numbers request)
    {
        if (request.GetCalcWanted() == "add")
        {
            Console.WriteLine(request.GetNumber1() + " + " + request.GetNumber2() + " = " + (request.GetNumber1() + request.GetNumber2()));
        }
        else
        {
            nextInChain.Calculate(request);
        }
    }
}