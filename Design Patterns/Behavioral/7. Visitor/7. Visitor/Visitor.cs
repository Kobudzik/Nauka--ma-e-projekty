using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Visitor
{
	public interface Visitor
	{
		// Created to automatically use the right 
		// code based on the Object sent
		// Method Overloading
		double Visit(Liquor liquorItem);

		double Visit(Tobacco tobaccoItem);

		double Visit(Necessity necessityItem);
	}
}
