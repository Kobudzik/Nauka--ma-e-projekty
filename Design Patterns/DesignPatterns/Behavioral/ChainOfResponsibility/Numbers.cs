using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Numbers
    {
        private readonly int number1;
        private readonly int number2;

        private readonly String calculationWanted;

        public Numbers(int newNumber1, int newNumber2, String calcWanted)
        {
            number1 = newNumber1;
            number2 = newNumber2;
            calculationWanted = calcWanted;
        }

        public int GetNumber1() { return number1; }
        public int GetNumber2() { return number2; }
        public String GetCalcWanted() { return calculationWanted; }
    }
}
