namespace Bridge.Implementer;

public interface IPaymentMethod
{
    void ProcessPayment(string paymentMethod);
}