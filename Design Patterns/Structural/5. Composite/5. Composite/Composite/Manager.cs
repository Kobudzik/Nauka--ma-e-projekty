using CompositeDesignPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Composite
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }    //property
        public string Department { get; set; }  //property
        public List<IEmployee> SubOrdinates;    //LIST of components

        public Manager(string name, string dept)    //constructor
        {
            this.Name = name;
            this.Department = dept;
            SubOrdinates = new List<IEmployee>();
        }


        public void GetDetails(int indentation)
        {
            Console.WriteLine();

            Console.WriteLine(string.Format(
                "{0}+ Name:{1}, Dept:{2} - Manager(Composite)",
                new String('-', indentation),
                this.Name.ToString(),
                this.Department));

            foreach (IEmployee component in SubOrdinates)
            {
                component.GetDetails(indentation + 1);
            }
        }
    }
}