using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.level2
{
    internal class MY_Function
    {
        public int SumNumber(int number1 ,int number2) { 
        
            int sum= number1 + number2;
            return(sum);

        }

        public int GetAnnual(int salary)
        {

            int annual = salary * 12;
            return (annual);

        }

        public  string[] Task1_Compute_Salary2(string name, int salary)
        {


            int annual = salary * 12;  //mark / fullmark*100

            string[] date = { name,annual.ToString()};


            return (date);
   
        }


        public double Task2_Compute_PCT2(string name, double mark, double fullmark)
        {


            double percentage = mark / fullmark * 100;
            return (percentage);

            
                
        }



        public static void Task1_Compute_Salary(string name, int salary)
        {
           

            int annual = salary * 12;  //mark / fullmark*100

            Console.WriteLine("Welcome:" + name);
            Console.WriteLine("My Salary:" + salary);
            Console.WriteLine("My Annual Salary:" + annual);

            if (annual >= 15000)

                Console.WriteLine("High Salary");

            else if (annual >= 10000)

                Console.WriteLine("Normal Salary");

            else if (annual >= 5000)

                Console.WriteLine("Low Salary");

            else

                Console.WriteLine("very Low Salary");



        }

        public static void Task2_Compute_PCT(string name, double mark, double fullmark)
        {


            double percentage = mark / fullmark * 100;


            Console.WriteLine("---------------------");
            Console.WriteLine("Student Name:" + name);
            Console.WriteLine("Student Mark:" + mark);
            Console.WriteLine("Student percentage:" + percentage + "%");

            if (percentage >= 85)
                Console.WriteLine("Grade: Excellent");
            else if (percentage >= 75)
                Console.WriteLine("Grade: Very Good");
            else if (percentage >= 65)
                Console.WriteLine("Grade: Good");
            else if (percentage >= 50)
                Console.WriteLine("Grade: Pass");
            else
                Console.WriteLine("Grade: Failed");
        }



       public    void Task3_Compute_BMI(string name, double height, double weight) 
        
        {


       

            double BMI = weight / (height * height);


            Console.WriteLine("---------------------");
            Console.WriteLine("Patient Name:" + name);
            Console.WriteLine("Patient Weight:" + weight);
            Console.WriteLine("Patient Height:" + height);
            Console.WriteLine("Patient BMI:" + BMI);

            if (BMI >= 25)
            {
                Console.WriteLine("Over Weight");

            }
            else
            {
                Console.WriteLine("Normal Weight");
            }



        }



    }
}
