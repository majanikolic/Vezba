using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodezad7
{
    class Program
    {   /*Napraviti metodu koja ce se zvati Uvecaj i koja ce imati jedan parametar i unutar metode ce se taj parametar uvecati za jedan. 
        Uradi prosledjivanje po vrednosti i po referenci*/
        public void Uvecaj (int x)
        {
           
           x = x + 1;//ovo je ispis unutar metode vrednost parametra  
            Console.WriteLine("Ispis unutar metode prosledjivanja po vrednosti-x={0}",x);
        }

        public void Uvecaj1(ref int y)
        {
            y = y + 1;
            Console.WriteLine("Ispis unutar metode prosledjivanja po referenci-y={0}", y);
        }



        static void Main(string[] args)
        {
            Program ime = new Program();

            Console.WriteLine("a=");
            int a;
            a = Convert.ToInt32(Console.ReadLine());


             ime.Uvecaj(a);

             Console.WriteLine("Vrednost parametra a, nakon poziva metode prosledjivanja po vrednosti je:{0}", a);
             

            ime.Uvecaj1(ref a);
            Console.WriteLine("Vrednost parametra a, nakon poziva metode prosledjivanja po referenci je:{0}", a);
            Console.ReadKey();
        }
    }
}
