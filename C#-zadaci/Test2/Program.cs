using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Napravi program digitron gde ce se traziti da korisnik unese dva realna broja a zatim da unese jednu od ponudjenih operacija koju hoce da izvrsi:+,-,*,/.
             I nakon toga da program napise koja je operacija izvrsena i koji je rezultat. */
            Console.WriteLine("Unesi dva realna broja,a i b");

            double a;
            Console.WriteLine("a=");
            a = Convert.ToDouble(Console.ReadLine());

            double b;
            Console.WriteLine("b=");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Operacije koje zelite izvrsiti:+,-,*,/");

            string izabrana_operacija;
            izabrana_operacija = (Console.ReadLine());



            if (izabrana_operacija=="+")
            {
                Console.WriteLine("Zbir={0}", a + b);
            }

            if (izabrana_operacija=="-")
            {
                Console.WriteLine("Razlika={0}", a - b);
            }
            if ( izabrana_operacija=="*")
            {
                Console.WriteLine("Proizvod={0}", a * b);
            }
            if ( izabrana_operacija=="/")
            {
                Console.WriteLine("Kolicnik={0}",a/b);
            }
            Console.ReadKey();




        }
    }
}
