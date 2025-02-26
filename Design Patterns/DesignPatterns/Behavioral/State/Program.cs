using System;

namespace State;

static class Program
{
    static void Main()
    {
        ATMMachine atmMachine = new();

        atmMachine.InsertCard();

        atmMachine.EjectCard();

        atmMachine.InsertCard();

        atmMachine.InsertPin(1234);

        atmMachine.RequestCash(2000);

        atmMachine.InsertCard();

        atmMachine.InsertPin(1234);

        Console.ReadKey();
    }
}
