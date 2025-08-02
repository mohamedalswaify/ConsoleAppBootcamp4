using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.OOP
{
    internal class Employee
    {
        public string name;
        private double _salary;



        public double Salary 
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                    this._salary = value;
                else
                    Console.WriteLine("Invalid Salary");

            } 
        }





        public Employee(string n , double s)
        {
            name = n;
            _salary = s;
            
        }

        public double CalculateAnnualSalary()
        { return _salary * 12; }

  
    }
}
