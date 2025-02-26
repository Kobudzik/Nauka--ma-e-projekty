using Bridge.Abstraction;

namespace Bridge.RefinedAbstraction;

public class NetBankingPayment : Payment
{
    public override void MakePayment()
    {
        _IPaymentMethod.ProcessPayment("NetBanking Payment");
    }
}
