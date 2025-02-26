using Bridge.Abstraction;
using Bridge.ConcreteImplementer;
using Bridge.RefinedAbstraction;
using System;

namespace Bridge;

static class Program
{
    static void Main()
    {
        Payment order = new CardPayment
        {
            _IPaymentMethod = new CitiPaymentMethod()
        };

        order.MakePayment();

        order._IPaymentMethod = new IDBIPaymentMethod();
        order.MakePayment();

        order = new NetBankingPayment
        {
            _IPaymentMethod = new CitiPaymentMethod()
        };

        order.MakePayment();

        Console.ReadKey();
    }
}