using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilezadatak12
{
    class Program
    {
        static void Main(string[] args)
        {   /*Uneti cenu proizvoda, kolicinu kao i nacin placanja(1-gotovina, 2-kredit,3-cekovi
            Izracunati ukupan iznos za placanje.Ako se uzima na kredit tada se iznos uvecava za 6%, 
            a za gotovinu se iznos smanjuje za 5%*/

            Console.WriteLine("Uneti cenu proizvoda, kolicinu i nacin placanja:1-gotovina,2-kredit,3-cekovi");

            int cena;
            int kolicina;

           

            Console.WriteLine("Cena= ");
            cena = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kolicina=");
            kolicina = Convert.ToInt32(Console.ReadLine());

            

            int placanje;
            Console.WriteLine("Izaberite nacin placanja");
            placanje = Convert.ToInt32(Console.ReadLine());

            if (placanje == 1)
            {


                Console.WriteLine("Gotovinski racun je:{0}din", cena * kolicina * 0.95);
            }
            if (placanje == 2)
            {
                Console.WriteLine("Racun,za placanje na kredit,iznosi:{0}din", cena * kolicina * 1.06);
            }

            if(placanje==3)
            {
                Console.Write("Racun za placanje cekovima iznosi:{0}din", cena * kolicina);

            }

            Console.ReadLine();
        }
    }
}
