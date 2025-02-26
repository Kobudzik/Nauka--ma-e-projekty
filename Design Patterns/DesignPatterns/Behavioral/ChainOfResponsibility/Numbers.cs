using System;

namespace ChainOfResponsibility;

public class Numbers(int newNumber1, int newNumber2, string calcWanted)
{
    private readonly int number1 = newNumber1;
    private readonly int number2 = newNumber2;

    private readonly string calculationWanted = calcWanted;

    public int GetNumber1() { return number1; }
    public int GetNumber2() { return number2; }
    public string GetCalcWanted() { return calculationWanted; }
}
