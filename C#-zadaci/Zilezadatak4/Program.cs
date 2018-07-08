using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilezadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uneti tri broja. Ispisati najveci i najmanji broj*/

            int a;
            int b;
            int c;

            int najveci;
            int najmanji;

            Console.WriteLine("Unesi tri broja");

            Console.WriteLine("a= ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b= ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("c= ");
            c = Convert.ToInt32(Console.ReadLine());

            najveci = a;


            if (b > najveci) 
            {
                najveci = b;
            }

            if (c>najveci)
            {
                najveci = c;
            }

            Console.WriteLine("Najveci broj je:{0}", najveci);
            


            najmanji = a;

            if (b < najmanji)
            {
                najmanji = b;
            }
             
            if (c<najmanji)
            {
                najmanji = c;
            }

            Console.WriteLine("Najmanji broj je:{0}", najmanji);
            Console.ReadKey();





        }
    }
}
