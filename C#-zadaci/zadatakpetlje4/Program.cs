using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakpetlje4
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Ispisati na konzoli sve brojeve u opsegu od 1 do 100 koji su deljivi sa 3 obrnutim redosledom*/ 

            for(int a=100; a>=1; a = a - 1)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine(a);
                }
            }

            Console.ReadLine();


        }
    }
}
