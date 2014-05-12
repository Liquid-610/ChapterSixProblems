using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Square
{
    class Program
    {
        public static int exponent(ref int a)
        {
            a = a*a;
            return a;
        }

        
        static void Main(string[] args)
        {

            Console.Write("Enter an Integer:");
            String input = Console.ReadLine();

            int n = Convert.ToInt32(input);

            exponent(ref n);
            

            int squ = exponent(ref n);

           

            Console.WriteLine("{0} = Squared", squ);
        }
    }
}
