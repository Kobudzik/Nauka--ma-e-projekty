namespace DesignPatterns.Bridge
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class CardPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentMethod.ProcessPayment("Card Payment");
        }
    }
}