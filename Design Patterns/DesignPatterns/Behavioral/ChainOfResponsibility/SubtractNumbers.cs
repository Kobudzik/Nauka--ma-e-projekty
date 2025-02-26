using System;

namespace ChainOfResponsibility;

internal class SubtractNumbers : IChain
{
    private IChain _nextInChain;

    public void SetNextChain(IChain nextChain)
    {
        _nextInChain = nextChain;
    }

    public void Calculate(Numbers request)
    {
        if (request.GetCalcWanted() == "sub")
        {
            Console.WriteLine(request.GetNumber1() + " - " + request.GetNumber2() + " = " + (request.GetNumber1() - request.GetNumber2()));
        }
        else
        {
            Console.WriteLine("Only works for add and substract!");
        }
    }
}