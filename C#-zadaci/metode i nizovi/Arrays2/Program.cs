using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Preko konzole se unosi dužina niza (maksimalno 10). Ako je dužina niza veća od 10, deklarisati je na 10 elemenata.
             * Nakon toga se preko for petlje unose int članovi niza.
             * Nakon unosa svih 10 članova, konzola se briše, a lista elemenata se ispisuje na konzoli.*/

            Console.WriteLine("Uneti duzinu niza");
            int duzinaNiza;
            duzinaNiza=Convert.ToInt32(Console.ReadLine());

           

            if (duzinaNiza > 10)
            {
                duzinaNiza = 10;
            }

            int[] niz = new int[duzinaNiza];


            for (int i = 0; i < 10; i = i + 1)
            {
                Console.WriteLine("Uneti {0}=i clan niza:", i);
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int j=0;j<10; j = j + 1)
            {
                Console.WriteLine("{0}, clan niza je:{1}", j,niz[j] );
            }

            Console.ReadKey();









        }
    }
}
