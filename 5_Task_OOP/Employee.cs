using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.Task_OOP
{
    internal abstract class Employee
    {

        public string Name {  get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
            
        }
        public abstract double GetNetSalary();

    }
}
