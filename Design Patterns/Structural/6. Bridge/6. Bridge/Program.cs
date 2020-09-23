using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment order = new CardPayment();
            order._IPaymentMethod = new CitiPaymentMethod();
            order.MakePayment();

            order._IPaymentMethod = new IDBIPaymentMethod();
            order.MakePayment();

            order = new NetBankingPayment();
            order._IPaymentMethod = new CitiPaymentMethod();
            order.MakePayment();

            Console.ReadKey();
        }
    }
}