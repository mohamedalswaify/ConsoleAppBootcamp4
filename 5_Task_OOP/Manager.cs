using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.Task_OOP
{
    internal class Manager :Employee
    {
        public double Bonus { get; set; }
        public Manager(string name ,double salary, double bonus) :base(name,salary)
        {
            this.Bonus = bonus;
        }
        public override double GetNetSalary()
        {
           return Salary +Bonus;
        }
    }
}
