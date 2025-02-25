namespace DesignPatterns.State
{
    public class ATMMachine
    {
        readonly IATMState hasCard;
        readonly IATMState noCard;
        readonly IATMState hasCorrectPin;
        readonly IATMState atmOutOfMoney;

        IATMState currentAtmState;

        public int cashInMachine = 2000;
        public bool correctPinEntered = false;

        public ATMMachine()
        {
            hasCard = new HasCard(this);
            noCard = new NoCard(this);
            hasCorrectPin = new HasPin(this);
            atmOutOfMoney = new NoCash(this);

            //default state
            currentAtmState = noCard;

            if (cashInMachine < 0)
            {
                currentAtmState = atmOutOfMoney;
            }
        }

        public void SetATMState(IATMState newATMState)
        {
            currentAtmState = newATMState;
        }

        public void SetCashInMachine(int newCashInMachine)
        {
            cashInMachine = newCashInMachine;
        }

        public void InsertCard()
        {
            currentAtmState.InsertCard();
        }

        public void EjectCard()
        {
            currentAtmState.EjectCard();
        }

        public void RequestCash(int cashToWithdraw)
        {
            currentAtmState.RequestCash(cashToWithdraw);
        }

        public void InsertPin(int pinEntered)
        {
            currentAtmState.InsertPin(pinEntered);
        }

        public IATMState GetYesCardState() { return hasCard; }
        public IATMState GetNoCardState() { return noCard; }
        public IATMState GetHasPin() { return hasCorrectPin; }
        public IATMState GetNoCashState() { return atmOutOfMoney; }
    }
}
