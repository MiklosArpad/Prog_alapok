using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamlalas_ciklussal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Írjuk a számokat 1-5-ig

            int szamlalo = 1;

            //1) WHILE - CIKLUSSAL:
            while (szamlalo <= 5)
            {
                Console.WriteLine(szamlalo);
                szamlalo++;
            }

            //Console.WriteLine("Kiléptünk a ciklusból");

            // DO-WHILE CIKLUSSAL:

            do
            {
                Console.WriteLine(szamlalo);
                szamlalo++;

            } while (szamlalo <= 5);

            Console.WriteLine("Kiléptünk a ciklusból");

            Console.ReadKey();
        }
    }
}
