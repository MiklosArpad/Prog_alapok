using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyedik_dia
{
    class Program
    {
        static void Main()
        {
            // 1. Feladat          // Írj programot, amely kiírja a felhasználó által adott összes paramétert!
            //Segítség: a paraméterek számát az args tömb hosszából tudjuk meg, amit
            //az args.length hivatkozás ad meg.

            //string[] args = { "Bence", "Árpi", "Valaki", "Foxi", "Maxi", "Senki" };

            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine(args[i]);
            //}

            //foreach (string nev in args)
            //{
            //    Console.WriteLine(nev);
            //}

            //2. Feladat //Írj programot, mely kiírja egymás mellé az 1 és 20 közé eső páros számokat!

            //for (int i = 0; i < 20; i+=2)
            //{
            //    Console.Write($"{i}, ");
            //}

            //for (int i = 1; i < 20; i ++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{i}, ");
            //    }
            //}
            //Console.ReadKey();

            //3. Feladat  //Módosítsuk az előző programot úgy, hogy ne az 1 és 20 közé eső páros,
            //hanem a paraméterként megadott két szám közé eső 3 - mal osztható
            //számokat listázzuk ki!

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //for (int i = a; i < b; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.Write($"{i}, ");
            //    }

            //}

            //Console.ReadKey();

            //7. Feladat //Készíts programot, amely a paraméterben megadott tetszőleges számú
            //paraméternek számítja ki a számtani közepét!

            //ÖSSZEGZÉS PROG. TÉTEL

            //int[] szamok = { 3, 5, 7, 53, 12, 3446, 57, 4, 34 };

            //int osszeg = 0;

            //foreach (int szam in szamok)
            //{
            //    osszeg += szam; //osszeg = osszeg+szam;
            //}
            //int tombHossza = szamok.Length;
            //double vegeredmeny = (double)osszeg / tombHossza;
            //Console.WriteLine(vegeredmeny);
            //Console.ReadKey();

            //8. Feladat. Legyen a paraméter egy 100 és 9999 közé eső szám! Írasd ki a képernyőre a
            //számjegyek összegét! A megoldáshoz használj ciklust!

            //int a = Convert.ToInt32(Console.ReadLine());

            //if (a > 100 && a < 9999)
            //{
            // jó a szám és mehet tovább a logika...
            //}

            //int szam;
            //do
            //{
            //    szam = Convert.ToInt32(Console.ReadLine());
            //} while (szam < 100 && szam > 9999); // rákényszeríted a FELHASZNÁLÓT, hogy amíg intervallumon kívül ad meg számot addig újra fusson a ciklusban a bekérés

        }

    }
}
