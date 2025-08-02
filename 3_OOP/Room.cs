using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4.OOP
{
    internal class Room
    {
     public   double Width;
        public double length;

        //ctor
        public Room(double width , double length)
        {
            Width = width;
            this.length = length;
            
        }

        public double GetArea()
            { return Width *length; }
   


    }
}
