using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ChainOfResponsibility
{
    class SubtractNumbers:Chain
    {
		private Chain nextInChain;


	public void setNextChain(Chain nextChain)
		{

			nextInChain = nextChain;

		}

	
	public void calculate(Numbers request)
		{

			if (request.getCalcWanted() == "sub")
			{
				Console.WriteLine(request.getNumber1() + " - " + request.getNumber2() + " = " +
						(request.getNumber1() - request.getNumber2()));
			}
			else
			{
				Console.WriteLine("Only works for add and substract!");
			}
		}
	}
}
