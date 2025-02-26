using System;

namespace State.ConcreteStates;

public class HasCard(ATMMachine newATMMachine) : IATMState
{
    readonly ATMMachine atmMachine = newATMMachine;

    public void InsertCard()
    {
        Console.WriteLine("You can only insert one card at a time");
    }

    public void EjectCard()
    {
        Console.WriteLine("Your card is ejected");
        atmMachine.SetATMState(atmMachine.GetNoCardState());
    }

    public void RequestCash(int cashToWithdraw)
    {
        Console.WriteLine("You have not entered your PIN");
    }

    public void InsertPin(int pinEntered)
    {
        if (pinEntered == 1234)
        {
            Console.WriteLine("You entered the correct PIN");
            atmMachine.correctPinEntered = true;
            atmMachine.SetATMState(atmMachine.GetHasPin());
        }
        else
        {
            Console.WriteLine("You entered the wrong PIN");
            atmMachine.correctPinEntered = false;
            Console.WriteLine("Your card is ejected");
            atmMachine.SetATMState(atmMachine.GetNoCardState());
        }
    }
}
