using System;

namespace State.ConcreteStates;

public class NoCash(ATMMachine newATMMachine) : IATMState
{
    public void InsertCard()
    {
        Console.WriteLine("We don't have any money");
        Console.WriteLine("Your card is ejected");
    }

    public void EjectCard()
    {
        Console.WriteLine("We don't have any money");
        Console.WriteLine("There is no card to eject");
    }

    public void RequestCash(int cashToWithdraw)
    {
        Console.WriteLine("We don't have any money");
    }

    public void InsertPin(int pinEntered)
    {
        Console.WriteLine("We don't have any money");
    }
}
