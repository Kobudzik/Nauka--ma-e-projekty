﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
			Animal sparky = new Dog();
			Animal tweety = new Bird();

			Console.WriteLine("Dog: " + sparky.TryToFly());

			Console.WriteLine("Bird: " + tweety.TryToFly());

			// This allows dynamic changes for flyingType
			sparky.SetFlyingAbility(new ItFlys());

			Console.WriteLine("Dog: " + sparky.TryToFly());
		}
	}
}
