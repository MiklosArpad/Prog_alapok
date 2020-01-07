using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("hello"); // kiir a konzolablakra + sört is tör
            // Console.Write(); // kiir a konzolablakra de nem tör sort
            //            Console.ReadKey(); // bekérés, de csak egy karaktert vár
            //Console.ReadLine(); // békérés, de ő karakterláncot

            // PÉLDÁK:


            // 1) String bekérés
            //string nev = Console.ReadLine();

            //Console.WriteLine(nev);

            // 2) Karakter bekérés
            //char karakter = Console.ReadKey().KeyChar;
            //Console.WriteLine(); // sortörés
            //Console.WriteLine(karakter);

            // Szám bekérés

            string konzolSzam = "12"; // string szám programkód során kerül ide "leirásra"
            int szamKonzol = Convert.ToInt32(konzolSzam); // 12 stringre

            string konzolSZamBeker = Console.ReadLine(); // string szám ez a program futása során kerül +leirásra"
            int szam = Convert.ToInt32(konzolSZamBeker); // bekérést konvertálom

            Console.WriteLine(konzolSzam); // megjelenités visszakonvertálja stringre
            Console.WriteLine(szam); // megjelenités miatt visszamegy strinbgbe

            Console.ReadKey();
        }
    }
}
