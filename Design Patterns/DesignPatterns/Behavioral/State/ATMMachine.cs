using State.ConcreteStates;

namespace State;

public class ATMMachine
{
    private readonly IATMState hasCard;
    private readonly IATMState noCard;
    private readonly IATMState hasCorrectPin;
    private readonly IATMState atmOutOfMoney;

    private IATMState _currentAtmState;

    public int cashInMachine = 2000;
    public bool correctPinEntered;

    public ATMMachine()
    {
        hasCard = new HasCard(this);
        noCard = new NoCard(this);
        hasCorrectPin = new HasPin(this);
        atmOutOfMoney = new NoCash(this);

        _currentAtmState = noCard; //default state

        if (cashInMachine < 0)
        {
            _currentAtmState = atmOutOfMoney;
        }
    }

    public void SetATMState(IATMState newATMState) => _currentAtmState = newATMState;

    public void SetCashInMachine(int newCashInMachine) => cashInMachine = newCashInMachine;

    public void InsertCard() => _currentAtmState.InsertCard();

    public void EjectCard() => _currentAtmState.EjectCard();

    public void RequestCash(int cashToWithdraw) => _currentAtmState.RequestCash(cashToWithdraw);

    public void InsertPin(int pinEntered) => _currentAtmState.InsertPin(pinEntered);

    public IATMState GetHasCardState() => hasCard;
    public IATMState GetNoCardState() => noCard;
    public IATMState GetHasPin() => hasCorrectPin;
    public IATMState GetNoCashState() => atmOutOfMoney;
}
