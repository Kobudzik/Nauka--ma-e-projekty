using System;

namespace ChainOfResponsibility.Chains;

internal class AddNumbers : IChain
{
    private const string _addOperation = "add";
    private IChain _next;

    // Defines the next Object to receive the
    // data if this one can't use it
    public void SetNextChain(IChain nextChain)
    {
        _next = nextChain;
    }

    // Tries to calculate the data, or passes it
    // to the Object defined in method setNextChain()
    public void Calculate(CalculationRequest request)
    {
        if (request.GetCalcWanted() == _addOperation)
        {
            Console.WriteLine(request.GetNumber1() + " + " + request.GetNumber2() + " = " + (request.GetNumber1() + request.GetNumber2()));
        }
        else
        {
            _next.Calculate(request);
        }
    }
}