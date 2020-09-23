using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Visitor
{
	public class Liquor : Visitable
	{
		private double price;

		public Liquor(double item)
		{
			price = item;
		}

		public double Accept(Visitor visitor)
		{
			return visitor.Visit(this);
		}

		public double GetPrice()
		{
			return price;
		}
	}
}
