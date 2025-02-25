namespace DesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(double ibmPrice, double aaplPrice, double googPrice);
    }
}
