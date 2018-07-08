using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_petlje
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Ispisati prirodne brojeve od 1 do 5
            for (int a=1; a <= 5; a = a + 1)
            {
                Console.WriteLine(a);
            }
                */
            /*2. Ispisati brojeve od 3 do 8 unazad

            

            for (int a=8;a>=3;a=a-1)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey(); */

            /*3.Ispisati brojeve od 1 do n

            int n;

            Console.WriteLine("Unesi broj");
            n = Convert.ToInt32(Console.ReadLine());

            

            for (int a = 1; a <= n; a = a + 1)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();*/


            /*4. Ispisati prirodne brojeve od k do n

            int k;
            int n;

            Console.WriteLine("k=");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());

            for (int a = k; a <= n; a=a+1)
            {
                Console.WriteLine(a);
            }

           if (k == n)
            {
                Console.WriteLine("Ukucali ste iste brojeve");
                    
            }
            if(k>n)
            {
                Console.WriteLine("K ne sme biti vece od N");
            }

            Console.ReadKey();*/

            /*5. Suma prvih 5 prirodnih brojeva

            int suma = 0;
            for (int a=1; a<=5; a = a + 1)
            {
                suma = suma + a;  
            }
            Console.WriteLine("Suma prvih 5 brojeva={0}", suma);
            Console.ReadKey(); */

            /*6.Suma prvih n prirodnih brojeva

            int n;
            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());

            int suma = 0;

            for (int a = 1; a <= n; a = a + 1)
            {
                suma = suma + a;
            }
            Console.WriteLine("Zbir prvih n brojeva je:{0}", suma);
            Console.ReadKey(); */

            /*7.Suma prirodnih brojeva od n do k 

            int n;
            int k;

            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("k=");
            k = Convert.ToInt32(Console.ReadLine());

            int suma = 0;

            for (int a = n; a <= k; a = a + 1)
            {
                suma = suma + a;
            }

            Console.WriteLine("Zbir brojeva od n do k je:{0}", suma);
            Console.ReadKey();*/

            /*8.Suma neparnih brojeva od 1 do n

            int n;

            Console.WriteLine("n:");
            n = Convert.ToInt32(Console.ReadLine());

            int suma = 0;

            for(int a=1; a<=n; a = a + 1)
            {
                if (a % 2!= 0)
                {
                    suma = suma + a;
                }

            }

            Console.WriteLine("Suma neparnih brojeva je:{0}", suma);
            Console.ReadKey();*/

            /*9.Suma parnih prirodnih brojeva od 1 do n

            int n;

            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());

            int suma = 0;
            
            for(int a = 1; a <= n; a = a + 1)
            {
                if (a%2==0)
                {
                    suma = suma + a;
                }
            }

            Console.WriteLine("Suma parnih brojeva od a do n je:{0}", suma);
            Console.ReadKey();*/

            /*ili na drugi nacin while

            int n;

            Console.WriteLine("n:");
            n=Convert.ToInt32(Console.ReadLine());

            int suma = 0;

            int a = 1;

            while (a <= n)
            {
            

                if (a % 2 == 0)
                {
                    suma = suma + a;
                   
                }
                a = a + 1; 
            }

            Console.WriteLine("suma parnih brojeva od 1 do n je:{0}",suma);
            Console.ReadLine();*/

            /*10. Proizvod prvih 5 prirodnih brojeva

            int proizvod = 1;

            for (int a = 1; a <= 5; a = a + 1)
            {
                proizvod = proizvod * a;
            }

            Console.WriteLine("Proizvod prvih 5 brojeva:{0}", proizvod);
            Console.ReadKey();*/

            /*ili sa while 

            int proizvod = 1;
            int a = 1;
            while (a <= 5)
            {
                proizvod = proizvod * a;
                a = a + 1;
            }
            Console.WriteLine("Proizvod prvih 5 prirodnih brojeva je:{0}", proizvod);
            Console.ReadKey();*/

            /*11.Proizvod prirodnih od 1 do n

            int n;
            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());

            int proizvod = 1;

            for(int a = 1; a<= n; a = a + 1)
            {
                proizvod = proizvod * a;

            }
            Console.WriteLine("Proizvod prirodnih brojeva od 1 do n je:{0}", proizvod);
            Console.ReadKey();*/

            /*12. Proizvod prirodnih od k do n

            int k;
            Console.WriteLine("k =");
            k = Convert.ToInt32(Console.ReadLine());

            int n;
            Console.WriteLine("n =");
            n = Convert.ToInt32(Console.ReadLine());

            int proizvod = 1;

            for(int a=k; a<=n; a = a + 1)
            {
                proizvod = proizvod * a;
            }
            Console.WriteLine("Proizvod brojeva od k do n je:{0}", proizvod);
            Console.ReadKey();*/

            /*13.Prebrojati parne od 1 do n

            int n;
            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());
            int brojac  = 0;

            for(int a=2; a <= n; a = a + 1)
            {
                if (a % 2 == 0)
                {
                    brojac = brojac + 1;
                }
            }
            Console.WriteLine("Ukupno parnih brojeva je:{0}", brojac);
            Console.ReadKey();*/

            /*Prebrojati parne od n do k

            int n;
            int k;

            Console.WriteLine("n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("k:");
            k = Convert.ToInt32(Console.ReadLine());

            int brojac = 0;

            for(int a = n; a <= k; a = a + 1)
            {
                if (a % 2 == 0)
                {
                    brojac = brojac + 1;
                }
            }

            Console.WriteLine("Ukupan broj parnih brojeva od n do k je:{0}", brojac);
            Console.ReadKey();*/

            /*14.Prebrojati deljive sa 3 u intervalu od 1 do n

            int n;
            Console.WriteLine("n:");
            n = Convert.ToInt32(Console.ReadLine());

            int brojac = 0;

            for(int a = 1; a <= n; a = a + 1)
            {
                if (a % 3 == 0)
                {
                    brojac = brojac + 1;
                }
            }

            Console.WriteLine("Ukupan broj deljivih sa 3 u intervalu od 1 do n:{0}",brojac);
            Console.ReadKey();*/

            /*15.Prebrojati neparne od 1 do n

            int n;
            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());

            int brojac = 0;

            for (int a = 1; a <= n; a = a + 1)
            {
                if (a%2!=0)
                {
                    brojac = brojac + 1;
                }
            }
            Console.WriteLine("ukupan broj neparnih brojeva:{0}", brojac);
            Console.ReadKey();*/

            /*22.Saberi prirodne brojeve do 100

            
            int b = 100;
            int zbir = 0;

            for(int a=1; a <= b; a = a + 1)
            {
                zbir = zbir + a;
            }

            Console.WriteLine("Zbir brojeva do 100 je:{0}", zbir);
            Console.ReadKey();*/

            /*23. Saberi parne prirodne do 100

            int b = 100;
            int zbir = 0;

            for (int a = 1; a <= b; a = a + 1)
            {
                if (a % 2 == 0)
                {
                    zbir = zbir + a;
                }
            }

            Console.WriteLine("Zbir parnih brojeva do 100={0}", zbir);
            Console.ReadKey();*/

            /*26.Ispisati sumu kvadrata prvih n prirodnih brojeva

            int n;
            Console.WriteLine("n:");
            n=Convert.ToInt32(Console.ReadLine());

            double sumakvadrata = 0;

            for(int a = 1; a <= n; a = a + 1)
            {
                sumakvadrata = sumakvadrata + Math.Pow(a,2);
            }

            Console.WriteLine("Suma kvadrata prvih n brojeva:{0}", sumakvadrata);
            Console.ReadKey();*/

            /*Ispisati sumu kvadratnih brojeva od k do n

            int k;
            Console.WriteLine("k:");
            k = Convert.ToInt32(Console.ReadLine());

            int n;
            Console.WriteLine("n:");
            n = Convert.ToInt32(Console.ReadLine());

            double sumakvadrata = 0;

            for (int a=k; a <= n; a = a + 1)
            {
                sumakvadrata = sumakvadrata + Math.Pow(a, 2);
            }

            Console.WriteLine("Suma kvadratnih brojeva od k do n={0}", sumakvadrata);
            Console.ReadKey();*/








        }
    }
}
