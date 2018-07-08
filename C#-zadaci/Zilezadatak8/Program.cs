using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilezadatak8
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*Napisati program koji na osnovu visine osobe ispisuje idealnu tezinu.
             * Idealna tezina za osobe muskog pola je:Visina-100, a za zenske osobe:Visina-110.
             Pol se unosi u obliku 1-muski, 2-zenski. */

          

            Console.WriteLine("Unesi pol:1=muski pol,2=zenski");
            int pol = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite visinu");
            double visina = Convert.ToInt32(Console.ReadLine());
            


            if (pol == 1)
            {
                Console.WriteLine("Vasa idealna tezina je:{0}", visina - 100);

            }
            if (pol == 2)
            {
                Console.WriteLine("Vasa idealna tezina je:{0}", visina - 110);
            }

            if (pol != 1 && pol != 2)
            {
                Console.WriteLine("Niste dobro uneli pol");
                    }

            Console.ReadKey();
        }
    }
}
