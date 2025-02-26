using FactoryMethod.AbstractProduct;

namespace FactoryMethod.ConcreteProducts;

public class HamAndMushroomPizza : Pizza
{
    private readonly decimal price = 8.5M;

    public override decimal GetPrice() => price;
}
