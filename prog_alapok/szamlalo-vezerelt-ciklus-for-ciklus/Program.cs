using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamlalo_vezerelt_ciklus_for_ciklus
{
    class Program
    {
        static void Main(string[] args)
        {
            // számláló-vezérelt ciklus: egyszer biztos lefut

            // int szamlalo = 0 -> ciklusváltozó
            // szamlalo < 10 -> feltétel
            // szamlalo++ -> léptetés
            // szamlalo (szamlalo = szamlalo+1, szamlalo+=1, szamlalo++)
            // szamlalo (szamlalo = szamlalo+2, szamallo+=2) 2 helyett bármely szám kerülhet oda
            for (int szamlalo = 1; szamlalo <= 10; szamlalo++) // ciklusfej -> legelső ciklusfutás során nincs léptetés
            {
                // Ciklusmag
                Console.WriteLine(szamlalo);
            }

            // 1. ciklusfutásnál: int szamlalo = 0; szamlalo < 10; ezek futnak le
            // a többinél: szamlalo++; szamlalo < 10;

            for (int szamlalo = 1; szamlalo <= 20; szamlalo += 4)
            {
                // Ciklusmag
                Console.WriteLine(szamlalo);
            }

            // for-ciklus tömbökkel

            int[] szamok = { 1, 4, 734, 13, 5, 57, 789, 78, 4, 34 };//0.-tól indexálódik


            // szamok.Length = 10
            for (int i = 0; i < szamok.Length; i++)
            {
                // ciklusmag
                Console.WriteLine(szamok[i]);
            }

            string[] nevek = { "Foxi", "Maxi", "Taxi", "Rex", "Oxi", "Poxy" };

            for (int indexSzam = 0; indexSzam < nevek.Length; indexSzam += 3)
            {
                Console.WriteLine(nevek[indexSzam]);
            }

            //foreach (string nev in nevek)
            //{
            //    Console.WriteLine(nev);
            //}

            Console.ReadKey();
        }
    }
}
