using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ChainOfResponsibility
{
    interface Chain
    {
        // Defines the next Object to receive the data
        // if this Object can't process it
        void setNextChain(Chain nextChain);

        // Either solves the problem or passes the data
        // to the next Object in the chain
        void calculate(Numbers request);
    }
}
