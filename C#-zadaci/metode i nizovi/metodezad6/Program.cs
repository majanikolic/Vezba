using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodezad6
{
    class Program
        /*Napraviti program koji trazi od korisnika da unese duzine stranica pravougaonika,
         a zatim treba u programu napraviti 2 metode za izracunavanje povrsine i obima pravougaonika.*/
    {   
        public int Povrsina(int a,int b)
        {
            int P;
            P = a * b;
            return P;
            
        }
        public int Obim (int a,int b)
        {
            int O;
            O = 2 * a + 2 * b;
            return O;
        }



        static void Main(string[] args)
        {
            Program n = new Program();

            Console.WriteLine("Unesi prvu stranicu pravougaonika:");
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesi drugu stranicu pravougaonika:");
            int b;
            b = Convert.ToInt32(Console.ReadLine());

            int promenljivaP;
            int promenljivaO;

            promenljivaP = n.Povrsina(a, b);

            promenljivaO = n.Obim(a, b);

            Console.WriteLine("Pravougaonik koji ima stranice a={0}cm i b={1}cm, povrsina mu je P={2}cm2, a obim-O={3}cm", a, b, promenljivaP, promenljivaO);
            Console.ReadKey();

          





        }
    }
}
