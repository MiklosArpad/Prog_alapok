using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tömbök adatszerkezetek
            // bármely típusú értékből tud "sokat" tárolni

            // típus[] tömbAzonosító = new típus[tömb hossza];
            int[] szamok = new int[10]; // 6 "hellyel" hoztam létre -> csak 6 db érték fér bele

            // ELŐRE IS FEL LEHET TÖLTENI
            //int[] eloreIrtTomb = { 1, 2, 3, 4, 5, 6 };
            //string[] tomb = { "Foxi", "Taxi", "Maxi" };

            // 0.-re 1, 1.-re 2 ...
            for (int i = 0; i < 10; i++)
            {
                //szamok[i] = i; // szamok[0] = 0;
                szamok[i] = i + 1; // szamok[0] = 0+1;
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    szamok[i] = i;
            //}

            for (int tombIndex = 0; tombIndex < szamok.Length; tombIndex++)
            {
                // index száma                                 // adott tömbből adott indexen lévő érték
                Console.WriteLine($"A {tombIndex}. indexen álló szám: {szamok[tombIndex]}");
            }

            //int szamlalo = 0;
            //foreach (int szam in szamok)
            //{
            //    Console.WriteLine($"A {szamlalo}. indexen álló szám: {szam}");
            //    szamlalo++;
            //}


            // SABLON

            string[] nevek = new string[5];

            // BEKÉRÉS
            for (int i = 0; i < nevek.Length; i++)
            {
                nevek[i] = Console.ReadLine(); // rögtön az indexedik helyre kérek a konzolról nevet
            }

            // KIÍRATÁS

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }

            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            Console.ReadKey();
        }
    }
}
