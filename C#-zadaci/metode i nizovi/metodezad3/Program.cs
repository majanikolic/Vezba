using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodezad3
{
    class Program
    {
        /* Napisati program koji ima metodu za izračunavanje sume brojeva od n do k.
             Program treba da trazi od korisnika da unese dva cela broja
             na primer n i k i nakon toga da izracuna sumu brojeva u tom opsegu od n do k.
             Racunanje treba da se obavi unutar metode.
             (Pomoc:Metoda ce imati dva parametra tipa int i vracace rezultat tipa int).*/
        public int Sum(int n, int k)
        {
            int suma = 0;

            for (int a = n; a <= k; a = a + 1)
            {
                suma = suma + a;
               
            }
            return suma;





        }

        static void Main(string[] args)
        {
            Program n = new Program();

            Console.WriteLine("a=");
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b=");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
           

            int suma1;

            if (a < b)
            {
                suma1 = n.Sum(a, b);
                Console.WriteLine("suma brojeva je:{0},", suma1);
            }

            else if (a > b)
            {
                suma1 = n.Sum(b, a);
                Console.WriteLine("suma brojeva je:{0},", suma1);
            }

            else
            {
                Console.WriteLine("oba broja su ista");
            }

          

            


            Console.ReadKey();


        }
    }
}
