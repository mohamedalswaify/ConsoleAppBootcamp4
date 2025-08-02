using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.OOP
{
    internal class Student
    {
        public string name;
        public double mark;
        public int fullMark;


        public Student(string n ,double m ,int f)
        {
            name = n;
            mark = m;
            fullMark = f;
            
        }
        public double GetPercentage()
        {
            double pct =mark/fullMark *100;
            return pct;
        }
        //weight/(height*height)
    }
}
