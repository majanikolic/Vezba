using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilezadatak6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uneti jedan broj.Ako je broj veci od 10 ispisati sledece poruke:
             Broj je veci od 10.Koren broja X je X.XX.
             U suprotnom ispisati sledece poruke:Broj je manji od 10.Kvadrat broja X je X.XX. */

            int x;

            Console.WriteLine("x= ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x>10)
            {
                Console.WriteLine("Broj je veci od 10");
                Console.WriteLine("Koren broja X je:{0}", Math.Sqrt(x));
            }
            if (x<10)
            {
                Console.WriteLine("Broj je manji od 10");
                Console.WriteLine("Kvadrat broja X je:{0}", Math.Pow(x,2));
            }
            Console.ReadKey();

        }
    }
}
