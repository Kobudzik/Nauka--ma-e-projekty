using System;

namespace ChainOfResponsibility.Chains;

internal class SubtractNumbers : IChain
{
    private const string _subOperation = "sub";
    private IChain _next;

    public void SetNextChain(IChain nextChain)
    {
        _next = nextChain;
    }

    public void Calculate(CalculationRequest request)
    {
        if (request.GetCalcWanted() == _subOperation)
        {
            Console.WriteLine(request.GetNumber1() + " - " + request.GetNumber2() + " = " + (request.GetNumber1() - request.GetNumber2()));
        }
        else
        {
            Console.WriteLine("End of processing");
        }
    }
}