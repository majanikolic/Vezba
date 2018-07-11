using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Deklarisati niz tipa String čiji su elementi dani u nedelji.
             * Napisati program u kom se preko konzole unosi broj (1-7), 
             * a na izlaz konzole se ispisuje odgovarajući dan kao član kreiranog niza.*/

            string [] dani = { "Ponedeljak", "Utorak", "Sreda", "Cetvrtak", "Petak", "Subota", "Nedelja" };

            Console.WriteLine("Unesi broj za odabir dana u sedmici:");
            int unetiBroj;
            unetiBroj = Convert.ToInt32(Console.ReadLine());

            if (unetiBroj<1 && unetiBroj > 7)
            {
                Console.WriteLine("Unesite broj od 1 do 7");
            }

            Console.WriteLine("Uneti broj je:{0}", dani[(unetiBroj - 1)]);

            Console.ReadKey();





        }
    }
}
