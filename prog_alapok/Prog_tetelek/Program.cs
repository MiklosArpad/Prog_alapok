using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_tetelek
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* 1) ÖSSZEGZÉS TÉTEL */
            //int[] arak = { 12000, 13500, 12300, 14560, 7000 };

            //int osszeg = 0;

            //foreach (int ar in arak)
            //{
            //    osszeg += ar; // osszeg = osszeg + ar
            //}

            //Console.WriteLine(osszeg);
            //Console.ReadKey();

            /* 2) MEGSZÁMLÁLÁS TÉTEL */

            //string[] nevek = { "Bence", "Bence", "Árpád", "Áron", "Áron", "Árpád", "Árpád" };

            //int darab = 0;

            //foreach (string nev in nevek)
            //{
            //    if (nev == "Áron")
            //    {
            //        darab++; // darab = darab + 1
            //    }
            //}

            //Console.WriteLine($"{darab} darab Áron van a tömbben");
            //Console.ReadKey();

            /* 3) ÁTLAG TÉTEL */
            // átlag = jegyek 9sszege osztva a jegyek darabszámával

            //int[] jegyek = { 5, 4, 4, 5 };

            //int osszeg = 0;
            //foreach (int jegy in jegyek)
            //{
            //    osszeg += jegy;
            //}

            // Fel kell tételezem, hogy az átlag tizedesszám lesz.
            // double változóba kell emiatt elmentenem -> képes tárolni tizedes számot!
            // 1. probléma, = jel után egy integer-t osztok integer-rel -> ennek int lesz az eredménye.
            // az integer elfér a double-ben, de csak azért mert double-be mentem el nem fogja meghagyni a tizedesvessző
            // utáni részeket. már az osztás művelet mivel integer az eredmény, ledarabolja a tizedes vessző utáni részt
            // és hát sajnos az is belefér a double típusba. (átlag változó)
            // MEGOLDÁS: az osztást típuskényszerítem (castolom) double-re, hogy az osztás eredménye
            // double értékkel végződjön -> int/int -> double (castoltam)
            // értelemszerűen a double eredmény is belefér a double-be.
            //double atlag = (double)osszeg / jegyek.Length;

            //Console.WriteLine("Az osztály átlaga programozásból: " + atlag);
            //Console.ReadKey();

            /* 4) MINIMUM-KERESÉS TÉTEL */
            //int[] szamok = { 88, 34, 5, 623 };

            //int min = int.MaxValue; // a legnagyobb integerről feltételezem hogy ő a legkisebb
            //foreach (int szam in szamok)
            //{
            //    if (szam < min)
            //    {
            //        min = szam;
            //    }
            //}

            //Console.WriteLine("A legkisebb elem a tömbben: " + min);
            //Console.ReadKey();

            /* 4) MAXIMUM-KERESÉS TÉTEL */
            int[] szamok = { 88, 34, 5, 623, 4, 1000 };

            int max = int.MinValue; //  a legkisebb integerről feltételezem hogy ő a legnagyobb
            foreach (int szam in szamok)
            {
                if (szam > max) // ha szám nagyobb a max-nál, akkor ő lesz max
                {
                    max = szam; // a max-ot átírom anagyobb számnra
                }
            }

            Console.WriteLine("A legnagyobb elem a tömbben: " + max);
            Console.ReadKey();
        }
    }
}
