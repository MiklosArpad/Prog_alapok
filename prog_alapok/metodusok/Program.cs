using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodusok
{
    public class Program
    {
        // C# színtisztán OOP nyelv
        // névterek -> class -> adattag és metódus (eljárás/függvény)
        // levegőbe nem szabad írni!!

        public static void Main(string[] args)
        {
            // program végrehajtás
            // fordító elkezdni fordítani a programot, ő a Main metódusban kezdi el az egész processz-t (folyamatot)

            // METÓDUS:
            // 1) Eljárás: void a visszatérési értéke: nem ad vissza semmit, csak lefut, ha hívják!
            // 2) Függvény: visszatér valamivel: int, String, double, Kutya

            // Metódusok: mire jó nekünk? hát egy nagyobb problémát kis részfeladatokra fel tudjuk osztani, hogy ÁTLÁTHATÓ legyen!!

            //1) 5x ki kell írnom a konzolra, hogy "SZIA"

            Console.WriteLine("SZIA");
            Console.WriteLine("ÁRPÁD");
            Console.WriteLine("SZIA");
            Console.WriteLine("ÁRPÁD");
            Console.WriteLine("SZIA");
            Console.WriteLine("ÁRPÁD");
            Console.WriteLine("SZIA");
            Console.WriteLine("ÁRPÁD");
            Console.WriteLine("SZIA");
            Console.WriteLine("ÁRPÁD");

            // Ctrl+C, Ctrl+V-tzni kell valamit programozásban, akkor az felveti a gyanút, hogy ez mehetne metódusba

            // REFAKTOR:

            // Meghívom az eljárást:

            Szia();
            Szia();
            Szia();
            Szia();
            Szia();


            // METÓDUS EGY VAlAMIÉRT LEHET FELELŐS

            Console.WriteLine(Szia2("BALÁZS"));

            Console.WriteLine(Osszead(100, 3));


            Console.ReadKey();
        }

        public static void Szia()
        {
            Console.WriteLine("SZIA");
            Console.WriteLine("ÁRPÁD");
        }

        public static string Szia2()
        {
            return "SZIA ÁRPÁD, EZ A MÁSODIK METÓDUS";
        }
        public static string Szia2(string nev)
        {
            return "SZIA " + nev + ", EZ A MÁSODIK METÓDUS";
        }

        public static int Osszead(int szam1, int szam2)
        {
            return szam1 + szam2;
        }
    }
}
