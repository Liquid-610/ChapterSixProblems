using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class Program
    {
        
        public static void InchesToFeet(int a)
        {
            Console.WriteLine("{0} Feet and {1} Inches",a/12, a % 12);
        }


       

        static void Main(string[] args)
        {
            int inches = 67;
            //int feet = inches % 12;
            InchesToFeet(inches);
            
            

        }
    
    }
}
