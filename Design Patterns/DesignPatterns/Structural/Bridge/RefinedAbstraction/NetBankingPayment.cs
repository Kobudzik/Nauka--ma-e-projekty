namespace DesignPatterns.Bridge
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class NetBankingPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentMethod.ProcessPayment("NetBanking Payment");
        }
    }
}
