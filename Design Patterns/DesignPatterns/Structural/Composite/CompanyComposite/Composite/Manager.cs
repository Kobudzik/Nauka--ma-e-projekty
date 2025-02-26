using CompanyComposite.Component;
using System;
using System.Collections.Generic;

namespace CompanyComposite.Composite;

public class Manager(string name, string department) : IEmployee
{
    public string Name { get; set; } = name;
    public string Department { get; set; } = department;
    public List<IEmployee> SubOrdinates = [];

    public void GetDetails(int indentation)
    {
        Console.WriteLine();

        Console.WriteLine(string.Format(
            "{0}+ Name:{1}, Dept:{2} - Manager(Composite)",
            new string('-', indentation),
            Name,
            Department)
        );

        foreach (IEmployee component in SubOrdinates)
        {
            component.GetDetails(indentation + 1);
        }
    }
}