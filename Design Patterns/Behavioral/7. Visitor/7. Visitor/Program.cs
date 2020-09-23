using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
			TaxVisitor taxCalc = new TaxVisitor();
			TaxHolidayVisitor taxHolidayCalc = new TaxHolidayVisitor();

			Necessity milk = new Necessity(3.47);
			Liquor vodka = new Liquor(11.99);
			Tobacco cigars = new Tobacco(19.99);

			Console.WriteLine(milk.Accept(taxCalc) + "\n");
			Console.WriteLine(vodka.Accept(taxCalc) + "\n");
			Console.WriteLine(cigars.Accept(taxCalc) + "\n");

			Console.WriteLine("TAX HOLIDAY PRICES\n");

			Console.WriteLine(milk.Accept(taxHolidayCalc) + "\n");
			Console.WriteLine(vodka.Accept(taxHolidayCalc) + "\n");
			Console.WriteLine(cigars.Accept(taxHolidayCalc) + "\n");

			Console.Read();
		}
    }
}
