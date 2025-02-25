namespace DesignPatterns.Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Payment
    {
        public IPaymentMethod _IPaymentMethod; //ACTUAL BRIDGE

        public abstract void MakePayment();
    }
}
