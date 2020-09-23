using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public abstract class GUIFactory
    {
        /// <summary>
        /// getFactory returns concrete Factory,
        ///instead parameter abstract Factory can get OS_Type from outer method
        /// </summary>
        /// <param name="type">Operating System</param>
        /// <returns></returns>
        public static GUIFactory GetFactory(OS_TYPE type)
        {
            switch (type)
            {
                case OS_TYPE.Windows:
                    return new WinFactory();

                case OS_TYPE.OsX:
                    return new OSXFactory();

                default:
                    throw new NotImplementedException();
            }
        }

        public abstract Button CreateButton();
    }
}
