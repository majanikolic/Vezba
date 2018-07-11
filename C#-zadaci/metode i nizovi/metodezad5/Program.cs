using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodezad5
{
    class Program
    {   /*Napravi program koji ce traziti od korisnika da unese neku rec a zatim jedan ceo broj.
        Nakon toga u programu treba napraviti i pozvati metodu koja ce datu rec odstampati onoliko puta koliko je broj korisnik uneo*/
        public void stampa(string unetaRec, int unetiBroj)
        {
            for (int a = 0; a < unetiBroj; a = a + 1)
            {
                Console.WriteLine("{0}", unetaRec);
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Unesi rec:"); //komande se unose u Main-ceo program se izvrsava samo u Main
            string rec;
            rec = Console.ReadLine();

            Console.WriteLine("Unesi broj");
            int broj;
            broj = Convert.ToInt32(Console.ReadLine());

            Program objekat = new Program();

            objekat.stampa(rec, broj);//pozivam metodu 

            Console.ReadKey();






        }
    }
}
