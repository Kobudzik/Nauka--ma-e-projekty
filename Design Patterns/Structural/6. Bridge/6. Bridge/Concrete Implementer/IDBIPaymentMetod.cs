using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class IDBIPaymentMethod : IPaymentMethod
    {
        public void ProcessPayment(string paymentMethod)
        {
            Console.WriteLine("Using IDBIBank gateway for  " + paymentMethod);
        }
    }
}
