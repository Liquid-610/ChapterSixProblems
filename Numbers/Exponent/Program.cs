using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent
{
    class Program
    {
        public static  int exponent(int a)
    {
            return a * a;
    }

        public static int cube(int a)
        {
            return a * a * a;
        }

        static void Main(string[] args)
        {
            
            Console.Write("Enter an Integer:");
           String input = Console.ReadLine();

            int n = Convert.ToInt32(input);

            exponent(n);
            cube(n);

            int squ = exponent(n);

            int cbu = cube(n);

            Console.WriteLine("{0} = squared, {1} = cubed", squ, cbu);
        }
    }
}
