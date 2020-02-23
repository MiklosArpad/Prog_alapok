using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kemia
{ 

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Felfedezes> felfedezesek = new List<Felfedezes>();


            var sorok = File.ReadAllLines("../../felfedezesek.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (string sor in sorok)
            {
                //Console.WriteLine(sor);
                string[] adatok = sor.Split(';'); 

                //PÉLDÁNYOSÍTÁS
                Felfedezes felfedezes = new Felfedezes(); 

                // SETTELÉS A TÖMBBŐL
                felfedezes.Ev = adatok[0]; // 
                felfedezes.Elem = adatok[1];// "fizikai"
                felfedezes.Vegyjel = adatok[2]; // "Rainer"
                felfedezes.Rendszam = Convert.ToInt32(adatok[3]); // "Weiss"
                felfedezes.Felfedezo = adatok[4];
                // Utolsó lépésként, hozzáadott az adott ciklusfutásban létrejött objektumot a listához
                felfedezesek.Add(felfedezes);
            }

            // 3. feladat: hány kémiai elem felfedezéséről van feljegyzés a fáljlban?
            // hány sor van a fájlban? 117-et KELL HOGY kapjunk!
            // van egy objektumlistánk, lementegettük az adatokat. 
            // egy sor -> 1 objektum = 117 objektumnak kell lennie a listában
            Console.WriteLine("3. feladat: Elemek száma: " + felfedezesek.Count);

            // 4. feladat: Ókorban hány db. elemet fedeztek fel?
            int db = 0;
            foreach (Felfedezes f in felfedezesek)
            {
                if (f.Ev == "Ókor")
                {
                    db++;
                }
            }
            Console.WriteLine("4. feladat: Felfedezések szám az ókorban: " + db);

            // 5. feladat: Az Sg vegyjelű felfedezés minden adatait írassa ki!
            foreach (Felfedezes f in felfedezesek)
            {
                if (f.Vegyjel == "Sg")
                {
                    Console.WriteLine("6. feladat: Keresés");
                    Console.WriteLine("Az elem vegyjele: " + f.Vegyjel);
                    Console.WriteLine("Az elem neve: " + f.Elem);
                    Console.WriteLine("Rendszáma: " + f.Rendszam);
                    Console.WriteLine("Felfedezés éve: " + f.Ev);
                    Console.WriteLine("Felfedező: " + f.Felfedezo);
                }
            }



            Console.ReadKey();

        }
    }
}
