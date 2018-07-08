using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zile_zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uneti dva broja.Ispisati prvo manji broj pa veci broj u obliku:manji broj je X, a veci broj je Y*/

            int x;
            int y;

            Console.WriteLine("x= ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y= ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                Console.WriteLine("Manji broj x={0}, a veci broj y={1}", x, y);
            
            }

            if(x>y)
            {
                Console.WriteLine("Veci broj je x={0}, a manji broj je y={1}",x,y);
            }

            if (x == y)
            {
                Console.WriteLine("X je jednako Y");
            }

            Console.ReadKey();




        }
    }
}
