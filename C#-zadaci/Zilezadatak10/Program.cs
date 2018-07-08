using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilezadatak10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite pol,visinu,tezinu");

            string pol;
            int visina;
            int tezina;
            
            

            Console.WriteLine("Pol:");
            pol = Console.ReadLine();

            Console.WriteLine("Visina:");
            visina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tezina:");
            tezina = Convert.ToInt32(Console.ReadLine());

            


            if (pol == "m" && tezina==visina- 100)
            {
                Console.WriteLine("Idealna tezina"  );
            }

            else if( pol=="m" && tezina<visina-100)
            {
                Console.WriteLine("Trebate se udebljati za:{0}kg", (double)visina -100 - tezina );
            }
            else if (pol=="m" && tezina > visina - 100)
            {
                Console.WriteLine("Trebate smrsati:{0}kg", (double)tezina - (visina-100));
            }

            
            if(pol=="z" && visina - 110 == tezina)
            {
                Console.WriteLine("Idealna vam je tezina");
            }
            if(pol=="z" && visina - 110 >tezina)
            {
                Console.WriteLine("Treba da se udebljate:{0}kg", (double)visina -110 - tezina);
            }

            if (pol == "z" && visina - 110 < tezina)
            {
                Console.WriteLine("Treba da smrsate:{0}kg", (double)tezina - (visina - 110));
            }
            if (pol!="z" && pol != "m")
            {
                Console.WriteLine("Za pol unesite oznaku m ili z");
            }
            Console.ReadKey();

        }
    }
}
