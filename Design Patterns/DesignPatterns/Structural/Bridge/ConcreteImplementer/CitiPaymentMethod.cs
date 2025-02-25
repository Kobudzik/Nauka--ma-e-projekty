using System;

namespace DesignPatterns.Bridge
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
