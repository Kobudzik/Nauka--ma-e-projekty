namespace State;

public interface IATMState
{
    // Different states expected
    // HasCard, NoCard, HasPin, NoCash

    void InsertCard();

    void EjectCard();

    void InsertPin(int pinEntered);

    void RequestCash(int cashToWithdraw);
}
