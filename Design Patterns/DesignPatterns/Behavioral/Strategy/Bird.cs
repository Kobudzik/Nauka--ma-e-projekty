namespace Strategy;

public class Bird : Animal
{
    public Bird()
    {
        SetSound("Tweet");

        // We set the Flys interface polymorphically
        // This sets the behavior as a flying Animal
        flyingType = new FlyingAnimal();
    }
}