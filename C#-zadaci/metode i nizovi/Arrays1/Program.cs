using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Preko konzole se unosi dužina niza(maksimalno 10). Ako je dužina niza veća od 10, deklarisati je na 10 elemenata.
                Nakon toga se preko for petlje unose int članovi niza.Nakon unosa prvog clana niza, 
                program autromatski popunjava ostale clanove i stvara duzinu niza 10.*/

            Console.WriteLine("Unesi duzinu niza");
            int duzinaNiza;
            duzinaNiza = Convert.ToInt32(Console.ReadLine());

            if (duzinaNiza>10)
            {
                duzinaNiza = 10;
            }

            int[] brojUnizu = new int[duzinaNiza];

            Console.WriteLine("Unesite prvi clan niza:");

            int unetiBroj = Convert.ToInt32(Console.ReadLine());


            for (int i=0; i < duzinaNiza; i = i + 1)
            {

                brojUnizu[i] = unetiBroj + i;
            }
         
            for(int j = 0; j < duzinaNiza; j = j + 1)
            {
                Console.WriteLine("{0}-i clan niza je {1}", j, brojUnizu[j]);
            }

            Console.ReadKey();








        }
    }
}
