namespace DesignPatterns.Bridge
{
    /// <summary>
    /// Implementor Interface
    /// </summary>
    public interface IPaymentMethod
    {
        void ProcessPayment(string paymentMethod);
    }
}