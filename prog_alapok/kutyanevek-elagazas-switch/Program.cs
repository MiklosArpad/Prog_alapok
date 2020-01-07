using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutyanevek_elagazas_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string nev = Console.ReadLine(); // konzolba irok az bekerül a readlineba

            if (nev == "Rex")
            {
                Console.WriteLine("a KUTYA NEVE Rex");
            }
            else if (nev == "Foxi")
            {
                Console.WriteLine("A kutya neve Foxi");
            }
            else if (nev == "Maxi")
            {
                Console.WriteLine("A kutya neve Maxi");
            }
            else
            {
                Console.WriteLine("A kutya neve nem Rex, Foxi, Maxi");
            }

            switch (nev) // Amire vizsgálunk
            {
                case "Rex": Console.WriteLine("a KUTYA NEVE Rex"); break; // Milyen esetekkel lehet == egyenlő
                case "Maxi": Console.WriteLine("A kutya neve Maxi"); break;
                case "Fox": Console.WriteLine("Kutya neve FOx"); break;
                case "Taxi": Console.WriteLine("Taxi kutya");break;
                default: Console.WriteLine("A kutya neve nem Rex, Foxi, Maxi"); break;
            }



            Console.ReadKey();
        }
    }
}
