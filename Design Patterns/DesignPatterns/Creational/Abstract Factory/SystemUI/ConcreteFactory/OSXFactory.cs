namespace DesignPatterns_AbstractFactory_OS
{
    public class OSXFactory : GUIFactory
    {
        public override Button CreateButton()
        {
            return new OSXButton();
        }
    }
}
