using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilezadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Napisati program koji za 3 uneta broja A,B i C odredjuje zbir dva najmanja*/

            int a;
            int b;
            int c;

            Console.WriteLine("a= ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b= ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("c=");
            c = Convert.ToInt32(Console.ReadLine());

            if (a < c && b < c)
            {
                Console.WriteLine("Zbir dva najmanja broja (aib)={0}", a + b);
            }
            if (a < b && c < b)
            {
                Console.WriteLine("Zbir dva najmanja broja (aic)={0}", a + c);

            }
            if (b < a && c < a)
            {
                Console.WriteLine("Zbir dva najmanja broja(bic) ={0 }", b + c);
            }
            if (a == b && b == c)
            {
                Console.WriteLine("Sva tri broja su jednaka");
            }

            Console.ReadKey();
        




        }
    }
}
