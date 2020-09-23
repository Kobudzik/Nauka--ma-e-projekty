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
    public class CitiPaymentMethod : IPaymentMethod
    {
        public void ProcessPayment(string paymentMethod)
        {
            Console.WriteLine("Using CitiBank gateway for  " + paymentMethod);
        }
    }
}
