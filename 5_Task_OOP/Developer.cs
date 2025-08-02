using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.Task_OOP
{
    internal class Developer :Employee
    {
        public double OvertimeHours { get; set; }
        public double HourlyRate { get; set; }

        public Developer(string name, double salary, double overtimeHours, double hourlyRate) : base(name, salary)
        {
            OvertimeHours = overtimeHours;
            HourlyRate = hourlyRate;
        }
        public override double GetNetSalary()
        {
            return Salary + (OvertimeHours* HourlyRate);
        }



    }
}
