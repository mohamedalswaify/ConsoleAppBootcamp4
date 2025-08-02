using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.OOP_V2
{
    internal class EmployeeHourly :Employee,IEmployee
    {

 
        public double Commisstion;
        public EmployeeHourly(string n, double s, double c):base(n,s)
        {

            Commisstion = c;
        }

        public override double GetNetSalary()
        {

            return (Salary + (Salary * Commisstion) )* 12;
        }

        public double GetNetSalary2()
        {
            throw new NotImplementedException();
        }
    }
}
