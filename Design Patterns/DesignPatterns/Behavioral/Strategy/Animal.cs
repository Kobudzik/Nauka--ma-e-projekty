using System;

namespace DesignPatterns.Strategy
{
    public class Animal
    {
        private String name;
        private double height;
        private int weight;
        private String favFood;
        private double speed;
        private String sound;

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

        public void SetName(String newName) { name = newName; }
        public String GetName() { return name; }

        public void SetHeight(double newHeight) { height = newHeight; }
        public double GetHeight() { return height; }

        public void SetWeight(int newWeight)
        {
            if (newWeight > 0)
            {
                weight = newWeight;
            }
            else
            {
                Console.WriteLine("Weight must be bigger than 0");
            }
        }
        public double GetWeight() { return weight; }

        public void SetFavFood(String newFavFood) { favFood = newFavFood; }
        public String GetFavFood() { return favFood; }

        public void SetSpeed(double newSpeed) { speed = newSpeed; }
        public double GetSpeed() { return speed; }

        public void SetSound(String newSound) { sound = newSound; }
        public String GetSound() { return sound; }

        /* BAD
		* You don't want to add methods to the super class.
		* You need to separate what is different between subclasses
		* and the super class
		public void fly(){

			System.out.println("I'm flying");

		}
		*/

        // Animal pushes off the responsibility for flying to flyingType

        public String TryToFly()
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
}
