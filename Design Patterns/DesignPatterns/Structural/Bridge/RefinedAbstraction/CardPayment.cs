using Bridge.Abstraction;

namespace Bridge.RefinedAbstraction;

public class CardPayment : Payment
{
    public override void MakePayment()
    {
        _IPaymentMethod.ProcessPayment("Card Payment");
    }
}