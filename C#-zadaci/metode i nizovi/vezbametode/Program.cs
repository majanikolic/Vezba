using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezbametode
{
    class Program
    {    /*Napravi program digitron koji od korisnika trazi da unese dva realna broja, i zatim da unese operaciju koju zeli da izvrsi,
        sabiranje, oduzimanje, mnozenje i deljenje. Za svaku operaciju realizovati metodu i koju ce kasnije koristiti unutar main funkcije.
        Pokriti slucaj kada je drugi uneti broj 0, tada ispisati poruku da je deljenje sa nulom nije moguce. Ispisati sve rezultate na konzolu.
        */

        


        public double Zbir (double a, double b)
        {

            return a + b;
        }

        public double Razlika (double a, double b)
        {
            return a - b;
        }

        public double Proizvod (double a, double b)
        {
            return a * b;
        }

        public double Kolicnik (double a, double b)
        {
            return a / b;           
        }





        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("a=");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b=");
            b = Convert.ToDouble(Console.ReadLine());

            Program Vezba = new Program();

            Console.WriteLine("Izaberi operaciju: zbir: + , oduzimanje: - , mnozenje: *  , deljenje: / ");
            string izabranaOperacija;
            izabranaOperacija = Console.ReadLine();

            if (izabranaOperacija == "+") 
            {
                Console.WriteLine("Zbir={0}",Vezba.Zbir(a,b));
            }
            if (izabranaOperacija == "-")
            {
                Console.WriteLine("Razlika={0}", Vezba.Razlika(a, b));
            }
            if (izabranaOperacija == "*")
            {
                Console.WriteLine("Proizvod={0}", Vezba.Proizvod(a, b));
            }

            if (izabranaOperacija == "/" )
            {
                if (b == 0)
                {
                    Console.WriteLine("Deljenje sa nulom nije moguce");
                }
                else
                {
                    Console.WriteLine("Kolicnik={0}", Vezba.Kolicnik(a, b));
                }
            }

            Console.ReadKey();



        }
    }
}
