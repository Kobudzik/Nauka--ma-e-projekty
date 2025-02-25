﻿using System;

namespace DesignPatterns.State
{
    public class NoCard : IATMState
    {
        readonly ATMMachine atmMachine;

        public NoCard(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Please enter your pin");
            atmMachine.SetATMState(atmMachine.GetYesCardState());
        }

        public void EjectCard()
        {
            Console.WriteLine("You didn't enter a card");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("You have not entered your card");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("You have not entered your card");
        }
    }
}
