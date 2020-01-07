using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bejaros_ciklus_foreach_ciklus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = { 1, 4, 734, 13, 5, 57, 789, 78, 4, 34 };
            int[] uresTomb = { };
            // foreach is mindig lefut
            // egy esetben nem fut le a foreach: ha üres a tömb, vagy az adatszerkezet

            // iterálás : ciklussal való végigfutás
            // int szam -> ciklusváltozó
            // in kulcsszó adatszerkezet azonosítójának a megadása
            foreach (int szam in szamok) // ciklusfej -> amilyen típusú az adatszerkezet amin végigiterálok, olyan típusú legyen a ciklusváltozó!!!
            {
                // ciklusmag
                Console.WriteLine(szam); // minden ciklusfutásban más értéket vesz fel
            }

            string[] nevek = { "Foxi", "Maxi", "Taxi", "Rex" };

            foreach (string nev in nevek) // ciklusfej -> amilyen típusú az adatszerkezet amin végigiterálok, olyan típusú legyen a ciklusváltozó!!!
            {
                // ciklusmag
                Console.WriteLine(nev); // minden ciklusfutásban más értéket vesz fel
            }

            Console.ReadKey();
        }
    }
}
