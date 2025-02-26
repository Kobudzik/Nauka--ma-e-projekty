using Bridge.Implementer;
using System;

namespace Bridge.ConcreteImplementer;

public class IDBIPaymentMethod : IPaymentMethod
{
    public void ProcessPayment(string paymentMethod)
    {
        Console.WriteLine("Using IDBIBank gateway for  " + paymentMethod);
    }
}
