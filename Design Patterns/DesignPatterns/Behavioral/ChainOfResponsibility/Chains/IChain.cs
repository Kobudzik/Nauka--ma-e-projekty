namespace ChainOfResponsibility.Chains;

interface IChain
{
    // Defines the next Object to receive the data
    // if this Object can't process it
    void SetNextChain(IChain nextChain);

    // Either solves the problem or passes the data
    // to the next Object in the chain
    void Calculate(CalculationRequest request);
}
