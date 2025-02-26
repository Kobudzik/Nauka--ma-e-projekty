using System;

namespace Template.Hoagies;

public class ItalianSandwich : Sandwich
{
    private readonly string[] meatUsed = ["Salami", "Pepperoni", "Capicola Ham"];
    private readonly string[] cheeseUsed = ["Provplone"];
    private readonly string[] veggiesUsed = ["Lettuce", "Tomatoes", "Onions", "Sweet Peppers"];
    private readonly string[] condimentsUsed = ["Oil", "Vinegar"];

    public override void AddCheese()
    {
        Console.WriteLine("Adding the cheese: ");
        foreach (string cheese in cheeseUsed)
            Console.Write(cheese + " ");
    }

    public override void AddCondiments()
    {
        Console.WriteLine("Adding the condiments: ");
        foreach (string condiments in condimentsUsed)
            Console.Write(condiments + " ");
    }

    public override void AddMeat()
    {
        Console.WriteLine("Adding the meat: ");
        foreach (string meat in meatUsed)
            Console.Write(meat + " ");
    }

    public override void AddVegetables()
    {
        Console.WriteLine("Adding the vegetables: ");
        foreach (string vegetables in veggiesUsed)
            Console.Write(vegetables + " ");
    }

    public void MakeSandwitch()
    {
        CutBun();
    }
}