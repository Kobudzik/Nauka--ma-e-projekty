using CompositeDesignPattern.Component;
using System;
using System.Collections.Generic;

namespace CompositeDesignPattern.Composite
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public List<IEmployee> SubOrdinates;

        public Manager(string name, string dept)
        {
            Name = name;
            Department = dept;
            SubOrdinates = new List<IEmployee>();
        }


        public void GetDetails(int indentation)
        {
            Console.WriteLine();

            Console.WriteLine(string.Format(
                "{0}+ Name:{1}, Dept:{2} - Manager(Composite)",
                new String('-', indentation),
                Name,
                Department));

            foreach (IEmployee component in SubOrdinates)
            {
                component.GetDetails(indentation + 1);
            }
        }
    }
}