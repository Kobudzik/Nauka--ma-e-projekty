using System;

namespace Strategy;

public class Animal
{
    private string _name;
    private double _height;
    private int _weight;
    private string _favFood;
    private double _speed;
    private string _sound;

    // Instead of using an interface in a traditional way
    // we use an instance variable that is a subclass
    // of the Flys interface.

    // Animal doesn't care what flyingType does, it just
    // knows the behavior is available to its subclasses

    // This is known as Composition : Instead of inheriting
    // an ability through inheritance the class is composed
    // with Objects with the right ability

    // Composition allows you to change the capabilities of 
    // objects at run time!

    public IFlys flyingType;

    public void SetName(string newName) { _name = newName; }
    public string GetName() { return _name; }

    public void SetHeight(double newHeight) { _height = newHeight; }
    public double GetHeight() { return _height; }

    public void SetWeight(int newWeight)
    {
        if (newWeight > 0)
        {
            _weight = newWeight;
        }
        else
        {
            Console.WriteLine("Weight must be bigger than 0");
        }
    }
    public double GetWeight() => _weight;

    public void SetFavFood(string newFavFood) => _favFood = newFavFood;
    public string GetFavFood() => _favFood;

    public void SetSpeed(double newSpeed) => _speed = newSpeed;
    public double GetSpeed() => _speed;

    public void SetSound(string newSound) => _sound = newSound;
    public string GetSound() => _sound;

    /* BAD
		* You don't want to add methods to the super class.
		* You need to separate what is different between subclasses
		* and the super class
		public void fly(){

			System.out.println("I'm flying");

		}
		*/

    // Animal pushes off the responsibility for flying to flyingType

    public string TryToFly()
    {
        return flyingType.Fly();
    }

    // If you want to be able to change the flyingType dynamically
    // add the following method

    public void SetFlyingAbility(IFlys newFlyType)
    {
        flyingType = newFlyType;
    }
}
