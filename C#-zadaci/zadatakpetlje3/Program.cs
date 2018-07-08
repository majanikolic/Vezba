using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakpetlje3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ispisati na konzoli sve  brojeve od 1 do 100 koji su deljivi sa 3*/

            Console.WriteLine("Brojevi do 100 koji su deljivi sa 3:");

            for (int a = 1; a <= 100; a = a + 1)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine(a);
                }
            }

            Console.ReadKey();
            




        }
    }
}
