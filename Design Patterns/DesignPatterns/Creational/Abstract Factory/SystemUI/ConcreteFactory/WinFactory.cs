namespace DesignPatterns_AbstractFactory_OS
{
    public class WinFactory : GUIFactory
    {
        public override Button CreateButton()
        {
            return new WinButton();
        }
    }
}
