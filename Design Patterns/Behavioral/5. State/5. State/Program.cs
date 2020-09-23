﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.State
{
    class Program
    {
        static void Main(string[] args)
        {
			ATMMachine atmMachine = new ATMMachine();

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
}
