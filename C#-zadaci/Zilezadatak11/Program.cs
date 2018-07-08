using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zilezadatak11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uneti dva broja i indikator operacije (1-sabiranje, 2-oduzivanje, 3-mnozenje,4-deljenje)
             Ispisati rezultat operacije u sledecem obliku Zbir brojeva je X ako izaberete 1....*/
            int a;
            int b;

            Console.WriteLine("Unesite dva broja");

            Console.WriteLine("a=");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b=");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Za zbir unetih brojeva ukucajte 1, razlika 2, proizvod 3, kolicnik 4");

            int izabrana_operacija;
            izabrana_operacija = Convert.ToInt32(Console.ReadLine());



           

            if (izabrana_operacija == 1)
            {
                Console.WriteLine("Zbir je:{0}", a + b);
            }

            if (izabrana_operacija == 2)
            {
                Console.WriteLine("Razlika je:{0}", a - b);
            }
            if (izabrana_operacija == 3)
            {
                Console.WriteLine("Proizvod je:{0}", a * b);
            }
            if (izabrana_operacija == 4)
            {
                Console.WriteLine("Kolicnik je:{0}", a / b);
            }

            Console.ReadKey();

        }
    }
}
