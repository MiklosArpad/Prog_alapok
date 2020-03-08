using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. LÉPÉS: MINDIG LEGYEN EGY POJO LISTA, EBBEN LESZ BENNE AZ 1859 DB FUVAR OBJEKTUM AZ ADATAIVAL (ADATTAGOKBAN TÁROLVA)
            List<Fuvar> fuvarok = new List<Fuvar>();

            // 2. LÉPÉS: SOROKAT OLVASSUK BE, HA KELL SKIPPELJÜK AZ ELSŐ SORT (FEJLÉC)
            List<string> sorok = File.ReadAllLines("../../fuvar.csv", Encoding.UTF8).Skip(1).ToList();

            //3. LÉPÉS: INDULJUNK EL CIKLUSSAL A SOROKON, HOGY MINDEN SORT EGYENKÉNT MEGKAPJUNK
            foreach (string sor in sorok) // 1859x fut le a ciklus, INDÍTSUNK EG
            {
                //4. LÉPÉS: A MEGKAPOTT SORT DARABOLJUK SZÉT A HATÁROLÓ KARAKTER MENTÉN (';'), ÉS MENTSÜK LE EGY STRING TÖMBBE
                string[] adatok = sor.Split(';');

                //5. LÉPÉS: PÉLDÁNYOSÍTSUNK EGY OBJEKTUMOT
                Fuvar f = new Fuvar();

                //. 6. LÉPÉS: SETTELJÜK BE AZ ADATTAGJAIT A STRING TÖMBBŐL KINYERT ADATOKKAL, HA KELL KONVERTÁLJUNK!!
                f.TaxiId = Convert.ToInt32(adatok[0]);
                f.Indulas = adatok[1];
                f.Idotartam = Convert.ToInt32(adatok[2]);
                f.Tavolsag = Convert.ToDouble(adatok[3]);
                f.Viteldij = Convert.ToDouble(adatok[4]);
                f.Borravalo = Convert.ToDouble(adatok[5]);
                f.FizetesModja = adatok[6];

                //7. LÉPÉS: ADJUK HOZZÁ A POJO LISTÁHOZ A BESETTELT OBJEKTUMOT/PÉLDÁNYT
                fuvarok.Add(f);
            }
            // Irassa ki, hány fuvar került feljegyzésre!
            // 3. feladat:        3. feladat: 1859 fuvar
            Console.WriteLine($"3. feladat: {fuvarok.Count} fuvar");

            // 4. feladat: Irassa ki hány fuvarja volt és mennyi volt bevétele a 6185 -ös számú taxinak!
            // MEGSZÁMLÁLÁS TÉTEL + ÖSSZEGZÉS TÉTEL

            int darab = 0;
            double osszeg = 0;

            foreach (Fuvar f in fuvarok)
            {
                if (f.TaxiId == 6185)
                {
                    osszeg += f.Viteldij + f.Borravalo;
                    darab++; // darab = darab + 1 VAGY darab += 1
                }
            }

            Console.WriteLine($"4. feladat: {darab} fuvar alatt: {osszeg} dollár");

            //fuvarok.Where(x => x.TaxiId == 6185).Sum(x => x.Viteldij + x.Borravalo); eza lambda operátor/expression

            //5. feladat: kategorizálni a fizetési módokat és összegezni hányszor használták

            SortedSet<string> fizetesiModok = new SortedSet<string>();

            foreach (Fuvar f in fuvarok) // 1859x lefut a ciklus, de egy fizetési mód egyszer lesz benne
            {
                fizetesiModok.Add(f.FizetesModja);
            }

            // EDDIG A HALMAZ TÁROLJA HOGY MILYEN KATEGÓRIÁK VANNAK, A HALMAZ MEGMONDJA HOGY 5 KÜLÖNBÖZŐ DARAB KAT. VAN: KP, BK, STB...

            int keszpenzDARAB = 0;
            int bankkartyaDARAB = 0;
            int ismeretlenDARAB = 0;
            int vitatottDARAB = 0;
            int ingyenesDARAB = 0;

            foreach (Fuvar f in fuvarok)
            {
                //    if (f.FizetesModja == "készpénz")
                //    {
                //        keszpenzDARAB++;
                //    }
                //    else if (f.FizetesModja == "bankkártya")
                //    {
                //        bankkartyaDARAB++;
                //    }
                //    else if (f.FizetesModja == "ismeretlen")
                //    {
                //        ismeretlenDARAB++;
                //    }
                //    else if (f.FizetesModja == "ingyenes")
                //    {
                //        ingyenesDARAB++;
                //    }
                //    else
                //    {
                //        vitatottDARAB++;
                //    }

                // IF-ELSEIF-ELSE kiváltható vele
                switch (f.FizetesModja) // fizetési mód az string
                {
                    case "készpénz": // case-ek csak stringk lehetnek
                        keszpenzDARAB++;
                        break;
                    case "bankkártya":
                        bankkartyaDARAB++;
                        break;
                    case "ismeretlen":
                        ismeretlenDARAB++;
                        break;
                    case "ingyenes":
                        ingyenesDARAB++;
                        break;
                    case "vitatott":
                        vitatottDARAB++;
                        break;
                }
            }

            Console.WriteLine("5. feladat:");
            Console.WriteLine($"\tbankkártya: {bankkartyaDARAB} fuvar");
            Console.WriteLine($"\tkészpénz: {keszpenzDARAB} fuvar");
            Console.WriteLine($"\tvitatott: {vitatottDARAB} fuvar");
            Console.WriteLine($"\tingyenes: {ingyenesDARAB} fuvar");
            Console.WriteLine($"\tismeretlen: {ismeretlenDARAB} fuvar");

            // /6. feladat: Összesen hány km -t tettek meg a taxisok (1 mérföld = 1,6 km)
            // ÖSSZEGZÉS TÉTEL
            double osszesUt = 0;

            foreach (Fuvar f in fuvarok)
            {
                osszesUt += f.Tavolsag * 1.6;  //A * 1.6 a km szorzója
            }

            // A zárójelben meghatározva a tizedes vessző utáni számok mennyisége, a tizedes vessző előtt mondig egy számjegy legyen!!!
            Console.WriteLine($"6. feladat: {osszesUt.ToString("0.00")} km");


            // 7. feladat: A leghosszabb időtartalmú fuvar adatai:

            int maxIdotartam = 0;   // maximu kerseésnél felvesszük a maxIdotartam nevű változót
            Fuvar fuvar = null;     // fuvar nevű üres objektum használata, hogy később ide mentse az adatokat


            foreach (Fuvar f in fuvarok)
            {
                if (maxIdotartam < f.Idotartam)
                {
                    maxIdotartam = f.Idotartam;

                    fuvar = f;
                }
            }

            Console.WriteLine("Leghosszabb fuvar:");
            Console.WriteLine($"\tFuvar hossza: {fuvar.Idotartam} másodperc");
            Console.WriteLine($"\tTaxi azonosító: {fuvar.TaxiId}");
            Console.WriteLine($"\tMegtett távolság: {fuvar.Tavolsag} mérföld");
            Console.WriteLine($"\tViteldíj: {fuvar.Viteldij}$");

            // 8. feladat: fájlba iratás a hibás sorok kiiratásanak. hibának tekintjük, amikor 0 a megtett távolság,
            //             akkor nem lehet 8 dollár a viteldíj:

            string eztirombeleafajlbatartalomkent = "taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja\n";

            foreach (Fuvar f in fuvarok)
            {
                if (f.Tavolsag == 0 && f.Viteldij > 0 && f.Idotartam > 0)
                {
                    //HIBÁS SOR, MENTJÜK A TARTALOM VÁLTOZÓBA
                    eztirombeleafajlbatartalomkent += f + "\n";
                }
            }

            File.WriteAllText("../../hibak.txt", eztirombeleafajlbatartalomkent, Encoding.UTF8); //TARTALOM KIÍRÓDIK FÁJLBA, AMI A HIBÁS SOROK HOSSZÚ STRINGJE

            Console.ReadKey();
        }
    }
}
