﻿using CompositeDesignPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Leaf
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }    //property
        public string Department { get; set; }  //property


        public Employee(string name, string dept)   //konstruktor
        {
            this.Name = name;
            this.Department = dept;
        }



        public void GetDetails(int indentation)
        {
            Console.WriteLine(string.Format(
                "{0}- Name:{1}, Dept:{2} (Leaf) ",
                new String('-', indentation),
                this.Name.ToString(),
                this.Department));
        }
    }
}