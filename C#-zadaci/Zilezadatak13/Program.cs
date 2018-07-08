using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilezadatak13
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Izracunati i ispisati porez na platu po sledecim kriterijumima. Za platu do 10000-porez je 10%, za platu od 10000 do 20000-porez je 12%,
             za platu od 20000 do 30000-porez je 15%, a za platu vecu od 30000-porez je 18%. */

            int plata;
            int porez;

            Console.WriteLine("Uneti iznos plate:");
            plata = Convert.ToInt32(Console.ReadLine());

            if (plata < 10000)
            {
                Console.WriteLine("Porez na platu je={0}din", plata * 0.10);
            }

            if (plata >= 10000 && plata < 20000)
            {
                Console.WriteLine("Porez na platu je:{0}din", plata * 0.12);
            }

            if (plata>=20000 && plata < 30000)
            {
                Console.Write("Porez na platu je={0}din", plata * 0.15);
            }

            if (plata >= 30000)
            {
                Console.WriteLine("Porez na platu je={0}", plata * 0.18);
            }

            Console.ReadLine();

        }
    }
}
