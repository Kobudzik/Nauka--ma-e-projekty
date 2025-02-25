using DecoratorDemo.Component;

namespace DecoratorDemo.ConcreteComponent
{
    public sealed class Hyndai : ICar
    {
        public string Make
        {
            get { return "HatchBack"; }
        }

        public double GetPrice()
        {
            return 800000;
        }
    }
}