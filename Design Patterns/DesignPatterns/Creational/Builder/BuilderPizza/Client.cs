using BuilderPizza.Director;

namespace BuilderPizza;

/// <summary>
/// pass that class a waiter and we will use him to construct pizza and write it
/// </summary>
public static class Client
{
    /// <summary>
    /// Simple method
    /// </summary>
    /// <param name="waiter">Returns waiter</param>
    public static void BuildAndDisplayPizza(Waiter waiter)
    {
        waiter.ConstructPizza();
        System.Console.WriteLine(waiter.Pizza);
    }
}
