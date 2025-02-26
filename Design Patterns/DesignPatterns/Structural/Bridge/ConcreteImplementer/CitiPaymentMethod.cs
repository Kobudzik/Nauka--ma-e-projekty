using Bridge.Implementer;
using System;

namespace Bridge.ConcreteImplementer;

public class CitiPaymentMethod : IPaymentMethod
{
    public void ProcessPayment(string paymentMethod)
    {
        Console.WriteLine("Using CitiBank gateway for  " + paymentMethod);
    }
}
