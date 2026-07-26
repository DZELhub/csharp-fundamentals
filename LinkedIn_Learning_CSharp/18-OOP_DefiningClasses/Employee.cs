using System;

namespace Defining
{
    public class Employee
    {
        string _name;
        string _department;
        decimal _salary;
        decimal _annualSalary;

        public Employee (string name, string department, decimal salary, decimal annualSalary)
        {
            _name = name;
            _department = department;
            _salary = salary;
            _annualSalary = annualSalary;
        }

        public decimal GetAnnualSalary ()
        {
            return _salary * 12;
        }

        public string GetDescription ()
        {
            return
            $"""
            {new string('=', 5)} EMPLOYEE {new string('=', 5)}

            {"Name",-14}: {_name}
            {"Department", -14}: {_department}
            {"Salary", -14}: {_salary:C} 
            {"Annual Salary", -14}: {GetAnnualSalary():C}
            """;
        }
    }
}