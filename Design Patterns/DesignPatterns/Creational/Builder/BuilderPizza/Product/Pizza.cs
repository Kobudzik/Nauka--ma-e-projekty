namespace BuilderPizza.Product;

public class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Topping { get; set; }

    public override string ToString()
    {
        return string.Format(
            "Pizza with Dough as {0}, Sauce as {1} and Topping as {2}",
            Dough,
            Sauce,
            Topping
        );
    }
}
