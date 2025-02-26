using Bridge.Implementer;

namespace Bridge.Abstraction;

public abstract class Payment
{
    public IPaymentMethod _IPaymentMethod; //ACTUAL BRIDGE

    public abstract void MakePayment();
}
