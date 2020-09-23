using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class WinButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Przycisk WinButton");
        }
    }
}
