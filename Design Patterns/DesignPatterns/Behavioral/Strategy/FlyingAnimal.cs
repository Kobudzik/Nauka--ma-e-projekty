namespace Strategy;

// The interface is implemented by many other
// subclasses that allow for many types of flying
// without effecting Animal, or Flys.

// Classes that implement new Flys interface
// subclasses can allow other classes to use
// that code eliminating code duplication

// I'm decoupling : encapsulating the concept that varies

public interface IFlyingAnimal
{
    string Fly();
}

class FlyingAnimal : IFlyingAnimal
{
    public string Fly() => "Flying High";
}

class NotFlyingAnimal : IFlyingAnimal
{
    public string Fly() => "I can't fly";
}
