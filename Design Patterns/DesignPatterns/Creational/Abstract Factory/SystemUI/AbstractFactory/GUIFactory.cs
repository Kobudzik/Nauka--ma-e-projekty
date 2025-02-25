using System;

namespace DesignPatterns_AbstractFactory_OS
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
