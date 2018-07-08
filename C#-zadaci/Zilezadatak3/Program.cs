using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilezadatak3
{
    class Program
    {
        static void Main(string[] args)
        {/*Uneti 3 broja. Ispisati vrednost najmanjeg broja*/

            int a;
            int b;
            int c;
            int najmanji;

            Console.WriteLine("Uneti tri broja");

            Console.WriteLine("a= ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b= ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("c= ");
            c = Convert.ToInt32(Console.ReadLine());

            najmanji = a;

            if (b < najmanji)
            {
                najmanji=b;
            }

            if (c < najmanji)
            {
                najmanji = c;
            }

            Console.WriteLine("Najmanji broj je={0}", najmanji);

            Console.ReadKey();


        }
    }
}

