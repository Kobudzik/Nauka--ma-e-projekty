using System;

namespace DesignPatterns.Bridge
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
