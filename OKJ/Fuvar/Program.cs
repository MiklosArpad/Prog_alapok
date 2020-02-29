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
            // 1. LÉPÉS: MINDIG LEGYEN EGY POJO LISTA
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





            Console.ReadKey();


        }
    }
}
