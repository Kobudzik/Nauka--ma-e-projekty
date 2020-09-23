using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class OSXFactory : GUIFactory
    {
        public override Button CreateButton()
        {
            return new OSXButton();
        }
    }
}
