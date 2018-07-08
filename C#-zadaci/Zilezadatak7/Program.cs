using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilezadatak7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uneti velicinu stana u m2. Za stan do 50m2 cena jednog m2 je 600evra, a za stanove preko 50m2 cena jednog m2 je 500evra.
             * Ispisati cenu stana u obliku Cena stana od X kvadrata je X.XX evra*/

            double x;

            Console.WriteLine("Velicina stana u metrima kvadratnim je:");

            x = Convert.ToDouble(Console.ReadLine());

            if (x <= 50)
            {
                Console.WriteLine("Cena stana je:{0}evra", x * 600);
            }
            if (x > 50) 
            {
                Console.WriteLine("Cena stana je:{0}evra", x * 500);
            }
            Console.ReadKey();


        }
    }
}
