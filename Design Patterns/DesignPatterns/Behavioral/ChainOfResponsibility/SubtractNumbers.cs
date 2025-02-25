using System;

namespace DesignPatterns.ChainOfResponsibility
{
    internal class SubtractNumbers : IChain
    {
        private IChain nextInChain;

        public void SetNextChain(IChain nextChain)
        {
            nextInChain = nextChain;
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
}