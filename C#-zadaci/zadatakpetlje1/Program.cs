using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakpetlje1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sabrati sve brojeve iz intervala od 1 do 100*/
            int suma=0;
            for (int a=1; a<=100; a=a+1)
            {
                suma = suma + a;
            }
            Console.WriteLine("Zbir prvih 100 brojeva je:{0}", suma);
            Console.ReadKey();


        }
    }
}
