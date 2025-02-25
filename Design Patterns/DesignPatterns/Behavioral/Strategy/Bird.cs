namespace DesignPatterns.Strategy
{
    public class Bird : Animal
    {
        // The constructor initializes all objects

        public Bird()
        {
            SetSound("Tweet");

            // We set the Flys interface polymorphically
            // This sets the behavior as a flying Animal
            flyingType = new ItFlys();
        }
    }
}