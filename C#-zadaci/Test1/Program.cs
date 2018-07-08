using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uradi program koji ce traziti da uneses imena i prezimena studenata, pa zatim broj bodova koje je dobio na ispitu.
              Kada uneses za jednog studenta podatke,program treba da ispise na ekranu uneto ime i prezime, kao i ocenu koju je dobio.
             Zatim ce traziti da uneses za sledeceg studenta i tako dalje sve dok ne uneses umesto imena rec "kraj".
              Kada uneses rec kraj,program treba nakon toga da prekine izvrsavanje i da napise na konzoli "Kraj programa".*/

                string imeiprezime;
            while (true)
            {
                Console.WriteLine("Ime i prezime studenta:");
                imeiprezime = (Console.ReadLine());

                 if (imeiprezime == "kraj")
                    {
                        Console.WriteLine("Kraj programa");
                        break;
                    }   


                int bodovi;
                    Console.WriteLine("Broj bodova:");
                    bodovi = Convert.ToInt32(Console.ReadLine());

                if (bodovi < 55)
                     {
                        Console.WriteLine("Pao");
                     }
                    
                if (bodovi >= 55 && bodovi < 65)
                    {
                        Console.WriteLine("Ocena:6");
                    }

                if (bodovi >= 65 && bodovi < 75)
                    {
                        Console.WriteLine("Ocena:7");
                    }

                if (bodovi >= 75 && bodovi < 85)
                    {
                        Console.Write("Ocena:8");
                    }
                if (bodovi >= 85 && bodovi < 95)
                    {
                        Console.WriteLine("Ocena 9");
                    }
                if (bodovi >= 95 && bodovi <= 100)
                    {
                    Console.WriteLine("Ocena 10");
                     }
                if (bodovi > 100)
                     {
                        Console.WriteLine("Niste ispravno uneli bodove");
                    }
            }

                    Console.ReadKey();


        }

     }
            
 }

    

