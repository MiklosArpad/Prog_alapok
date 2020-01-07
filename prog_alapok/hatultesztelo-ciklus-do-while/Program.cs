using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatultesztelo_ciklus_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // Azért hátultesztelős ciklus,
            // ez tuti hogy lefut egyszer...
            // elől megnézi a feltétel teljesül-e...

            string nev = "Foxi";

            do
            {
                //Ciklusmag
                Console.WriteLine("Foxi a kutya neve");
                nev = "Maxi"; // Ha nem írom át a nevet Maxira, akkor hátul mindig igaz lesz a kiértékelés (mindig Foxi a kutya neve)
                // Végtelen ciklus
            } while (nev == "Foxi");

            Console.ReadKey();
        }
    }
}
