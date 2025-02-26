using CompanyComposite.Component;
using CompanyComposite.Composite;
using CompanyComposite.Leaf;
using System;

namespace CompanyComposite;

static class Program
{
    static void Main()
    {
        IEmployee John = new Employee("John", "IT");
        IEmployee Mike = new Employee("Mike", "IT");
        IEmployee Jason = new Employee("Jason", "HR");
        IEmployee Eric = new Employee("Eric", "HR");
        IEmployee Henry = new Employee("Henry", "HR");

        IEmployee James = new Manager("James", "IT")
        {
            SubOrdinates = { John, Mike }
        };

        IEmployee Philip = new Manager("Philip", "HR")
        {
            SubOrdinates = { Jason, Eric, Henry }
        };

        IEmployee Bob = new Manager("Bob", "Head")
        {
            SubOrdinates = { James, Philip }
        };

        Bob.GetDetails(1);
        Console.ReadLine();
    }
}
