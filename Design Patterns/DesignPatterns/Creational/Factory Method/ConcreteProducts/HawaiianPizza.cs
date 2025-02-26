using FactoryMethod.AbstractProduct;

namespace FactoryMethod.ConcreteProducts;

public class HawaiianPizza : Pizza
{
    private readonly decimal price = 11.5M;

    public override decimal GetPrice() => price;
}
