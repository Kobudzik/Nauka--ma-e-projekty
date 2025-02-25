using System;

namespace DesignPatterns.Strategy
{
    // The interface is implemented by many other
    // subclasses that allow for many types of flying
    // without effecting Animal, or Flys.

    // Classes that implement new Flys interface
    // subclasses can allow other classes to use
    // that code eliminating code duplication

    // I'm decoupling : encapsulating the concept that varies

    public interface IFlys
    {
        String Fly();
    }

    // Class used if the Animal can fly
    class ItFlys : IFlys
    {
        public String Fly()
        {
            return "Flying High";
        }
    }

    //Class used if the Animal can't fly
    class CantFly : IFlys
    {
        public String Fly()
        {
            return "I can't fly";
        }
    }
}
