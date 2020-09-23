using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Observer
{
	public interface Observer
	{
		void Update(double ibmPrice, double aaplPrice, double googPrice);
	}
}
