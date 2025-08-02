using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.OOP_V2
{
    internal class EmployeeBasic :Employee
    {
   
        public double OverTime;


        public EmployeeBasic(string n, double s,double o) :base(n,s)
        {
          
            OverTime = o;

        }
        public override double GetNetSalary()
        {

            return (Salary + OverTime) * 12;
        }

    }
}
