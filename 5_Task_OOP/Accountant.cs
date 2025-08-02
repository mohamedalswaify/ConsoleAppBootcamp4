using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.Task_OOP
{
    internal class Accountant :Employee
    {
        public double TaxDeduction { get; set; }

        public Accountant(string name ,double salary ,double tax):base(name,salary)
        {
            TaxDeduction = tax;
            
        }

        public override double GetNetSalary()
        {
           return Salary-TaxDeduction;
        }
    }
}
