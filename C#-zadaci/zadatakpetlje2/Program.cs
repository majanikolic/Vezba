using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakpetlje2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Napisati program koji izracunava zbir parnih brojeva do 100. */

            int suma = 0;

            for(int a=1; a<=100; a=a+1)
            {
                if (a % 2 == 0)
                {
                    suma = suma + a;
                }
            }
            Console.WriteLine("Zbir parnih brojeva do 100 je:{0}", suma);
            Console.ReadKey();




        }
    }
}
