using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse4
{
    class Program
    {
        public static void Revthat(ref int a, ref int b, ref int c, ref int d)
        {
            int temp = a;
            int temp2 = b;
            a = d;
            d = temp;
            b = c;
            c = temp2;




        }

        static void Main(string[] args)
        {
            int fi = 1;
            int si = 2;
            int ti = 3;
            int hi = 4;
            Revthat(ref fi, ref si, ref ti, ref hi);

            Console.Write("{0} {1} {2} {3}", fi, si, ti, hi);

        }
    }
}
