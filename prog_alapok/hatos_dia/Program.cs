using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatos_dia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tömb deklarálása:
            // típus + tömboperátor+a változó azonosítója +érétkadó operátor+new +típus+tömb operátorba megadni milyen hosszú a tömb
            //int[] szamok = new int[10]; 0. 1. 2. 3. 4. 5. 6. 7. 8. 9.


            //int[] szamok = new int[5]; // {2,666,123 ,234,246} 1x5
            //szamok[0] = 2;
            //szamok[1] = 666;
            //szamok[2] = 123;
            //szamok[3] = 234;
            //szamok[4] = 246;
            ////  szamok[5] = 2; // el száll, ez a 6. elem, az 5. sorszámmal

            //string[] szekek = new string[3]; // 3 helyet foglaltam a moziban

            //// {"Bence", "Árpád", "Áron"}
            //szekek[0] = "Bence"; // moziban lévő első székre, aminek a sroszáma a 0., ott Bence foglal helyet
            //szekek[1] = "Áprád";
            //szekek[2] = "Áron";
            ////szekek[3] = "Balázs"; // el száll, Balázs nem fér oda a 3 székhez 4 ember

            //foreach (string emberek in szekek)
            //{
            //    Console.WriteLine(emberek);
            //}

            // ---------------- VEKTOR ---------------------------------------------

            //// ------- MÁTRIX ---------------------------------------------

            //string[,] matrix = new string[2, 3]; // 2 sor, 3 oszlop

            //// matrix = { 1.sor:{1,6,7}, 2.sor:{4,5,9} };
            ///

            //1. Feladat. Írj programot, amely definiál egy 10 hosszú, integer alaptípusú tömböt, és
            // feltölti a felhasználótól bekért értékekkel! A végén írja ki a vektorelemeket
            // a képernyőre!

            int[] szamok = new int[10];

            //szamok[0] = 2;
            //szamok[1] = 666;
            //szamok[2] = 123;
            //szamok[3] = 234;
            //szamok[4] = 246;
            //szamok[5] = 12;
            //szamok[6] = 6661;
            //szamok[7] = 1323;
            //szamok[8] = 5234;
            //szamok[9] = 1246;

            //for (int index = 0; index < szamok.Length; index++)
            //{
            //    Console.WriteLine($"Kérek egy számot a tömb {index}. indexére!");
            //    // itt kell bekérni az adott számot!
            //    szamok[index] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (int szam in szamok)
            //{
            //    Console.WriteLine(szam);
            //}
            //Console.ReadKey();

            string[] nevek = new string[5];

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine($"Kérek egy nevet a tömb {i}. indexére!");
                nevek[i] =Console.ReadLine();
            }
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }
            Console.ReadKey();
        }
    }
}
