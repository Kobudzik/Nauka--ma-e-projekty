using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.State
{
	public class ATMMachine
	{

		ATMState hasCard;
		ATMState noCard;
		ATMState hasCorrectPin;
		ATMState atmOutOfMoney;

		ATMState currentAtmState;

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

		public void SetATMState(ATMState newATMState)
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

		public ATMState GetYesCardState() { return hasCard; }
		public ATMState GetNoCardState() { return noCard; }
		public ATMState GetHasPin() { return hasCorrectPin; }
		public ATMState GetNoCashState() { return atmOutOfMoney; }
	}
}
