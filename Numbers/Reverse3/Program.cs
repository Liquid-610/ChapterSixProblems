using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse3
{
    class Program
    {
       public static void Revthat (ref int a, ref int b, ref int c)
        {
            int temp = a;
            a = c;
            c = temp;



 
        }

        static void Main(string[] args)
        {
            int fi = 1;
            int si = 2;
            int ti = 3;
            Revthat(ref fi, ref si, ref ti);

            Console.Write("{0} {1} {2}", fi, si, ti);
            
        }
    }
}
