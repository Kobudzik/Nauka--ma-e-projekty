using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Observer
{
	public interface Subject
	{
		void Register(Observer o);
		void Unregister(Observer o);
		void NotifyObserver();
	}
}