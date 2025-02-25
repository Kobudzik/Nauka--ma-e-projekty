using DesignPatterns.Composite.Component;
using System;

namespace DesignPatterns.Composite.Leaf
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name, string dept)
        {
            Name = name;
            Department = dept;
        }

        public void GetDetails(int indentation)
        {
            Console.WriteLine(string.Format(
                "{0}- Name:{1}, Dept:{2} (Leaf) ",
                new String('-', indentation),
                Name,
                Department));
        }
    }
}