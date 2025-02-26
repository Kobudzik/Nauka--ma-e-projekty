using Visitor.VisitableClasses;

namespace Visitor;

public interface IVisitor
{
    // Created to automatically use the right
    // code based on the Object sent
    // Method Overloading
    double Visit(Liquor liquorItem);

    double Visit(Tobacco tobaccoItem);

    double Visit(Necessity necessityItem);
}
