namespace ChainOfResponsibility;

public class CalculationRequest(int number1, int number2, string calculationWanted)
{
    private readonly int number1 = number1;
    private readonly int number2 = number2;

    public int GetNumber1() => number1;
    public int GetNumber2() => number2;
    public string GetCalcWanted() => calculationWanted;
}
