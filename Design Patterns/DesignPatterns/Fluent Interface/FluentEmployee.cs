﻿using System;

namespace FluentInterface;

public class FluentEmployee
{
    private readonly Employee employee = new(); //base class ref

    //Methods setting Properties
    public FluentEmployee NameOfTheEmployee(string FullName)
    {
        employee.FullName = FullName;
        return this;
    }

    public FluentEmployee Born(string DateOfBirth)
    {
        employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
        return this;
    }

    public FluentEmployee WorkingOn(string Department)
    {
        employee.Department = Department;
        return this;
    }

    public FluentEmployee StaysAt(string Address)
    {
        employee.Address = Address;
        return this;
    }
}