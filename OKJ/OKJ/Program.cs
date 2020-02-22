using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // FÁJLHOZZÁFÉRÉSHEZ SZÜKSÉGES ELŐRE KÉSZ FÜGGVÉNYEK

namespace OKJ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 2. feladat:
            // FÁJLBEOLVASÁS KEZDETE

            // 1. lépés: szemrevételeztem a fájl alapján, hogy 923 objektumom lesz, mert ennyi sor van a fájlban
            // tehát 923 objektumot kell létrehozzak!
            // őket el kell tároljam! lementjük egy listába!
            // Létrehozom a listát:

            List<Nobel> nobelDijasok = new List<Nobel>(); // létrehoztam a Nobel típusú objektumokat tároló Nobel típusú listát (ebben lesz ez a 923 objektum letárolva memória szintjén)

            // 2. lépés: FÁJLBEOLVASÁS
            // megadom neki első paraméterben az útvonalat, utána megadom hogy UTF-8ban olvassa be
            // utána ráhívom a Skip() függvényt és beleírom a paraméterébe, hogy 1, így egy sort kihagyva olvas, azaz a fejléc nem olvasódik be
            var sorok = File.ReadAllLines("../../nobel.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (string sor in sorok) // 923x fut le a foreach
            {
                //Console.WriteLine(sor);
                string[] adatok = sor.Split(';'); // "2017;fizikai;Rainer;Weiss" => ["2017", "fizikai", "Rainer", "Weiss"] // 4 elemű string tömböt ad vissza a Split

                //PÉLDÁNYOSÍTÁS
                Nobel nobel = new Nobel(); // 923 objektum, mert 923x lefut a ciklusmagban a példányosítás

                // SETTELÉS A TÖMBBŐL
                nobel.Ev = Convert.ToInt32(adatok[0]); // "2017"
                nobel.Tipus = adatok[1];// "fizikai"
                nobel.Keresztnev = adatok[2]; // "Rainer"
                nobel.Vezeteknev = adatok[3]; // "Weiss"

                // Utolsó lépésként, hozzáadott az adott ciklusfutásban létrejött objektumot a listához
                nobelDijasok.Add(nobel);
            }

            // FÁJLBEOLVASÁS VÉGE

            // FELADATOK: KALKULÁCIÓK, MŰVELETEK (SZŰRÉS)

            // 3. feladat: Arthur B. McDonald milyen díjat kapott ???
            // 923 objketumból feltételt kell állítsak akinek a neve a fenti, az milyen díjat kapott...
            foreach (Nobel n in nobelDijasok) // elindulok a már kész objektum listán
            {
                if (n.Keresztnev == "Arthur B." && n.Vezeteknev == "McDonald")
                {
                    // ha ide belefut, akkor be van azonosítva feltétel alapján a keresendő objektum
                    Console.WriteLine("3. feladat: Arthur B. McDonald Nobel-díjának a típusa: " + n.Tipus);
                    break; // kilép a foreach-ből
                }
            }

            // 4. feladat: Ki kapott 2017-ben irodalmi típusú Nobel-díjat???
            foreach (Nobel n in nobelDijasok)
            {
                if (n.Ev == 2017 && n.Tipus == "irodalmi")
                {
                    Console.WriteLine("4. feladat: " + n.Keresztnev + " " + n.Vezeteknev);
                    break;
                }
            }


            Console.ReadKey();
        }
    }
}
