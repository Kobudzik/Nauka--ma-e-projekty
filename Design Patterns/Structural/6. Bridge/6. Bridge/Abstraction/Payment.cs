using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    /// <summary>
    /// Abstraction 
    /// </summary>
    public abstract class Payment
    {
        public IPaymentMethod _IPaymentMethod; //ACTUAL BRIDGE

        public abstract void MakePayment();
    }
}
