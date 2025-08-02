using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.OOP
{
    internal class Patient
    {
        public string name;
        private double weight;
        private double height;

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double weight)
            {

            if (weight >= 0)
                this.weight = weight;
            else
                Console.WriteLine("Invalid Weight");
        
        }







        public Patient(string n ,double w,double h)
        {
            name = n;
            weight = w;
            height = h;
            
        }

        public double GetBMI()
        {
            double bmi = weight / (height * height);
            return bmi;
        }
    }
}
