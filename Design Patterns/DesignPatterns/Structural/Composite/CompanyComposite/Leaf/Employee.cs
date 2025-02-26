using CompanyComposite.Component;
using System;

namespace CompanyComposite.Leaf;

public class Employee(string name, string department) : IEmployee
{
    public string Name { get; set; } = name;
    public string Department { get; set; } = department;

    public void GetDetails(int indentation)
    {
        Console.WriteLine(string.Format(
            "{0}- Name:{1}, Dept:{2} (Leaf) ",
            new string('-', indentation),
            Name,
            Department)
        );
    }
}