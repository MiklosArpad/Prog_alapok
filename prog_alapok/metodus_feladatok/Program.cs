using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodus_feladatok
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Algoritmus: Véges számú lépések/utasítások sorozata

            // 1) összege a tömb elemeit függvénnyel!

            int[] szamok = { 1, 2, 3, 4, 5 };
            int[] szamok2 = { 100, 10, 1000, 1000000 };

            Matek m = new Matek();

            Console.WriteLine(m.OsszegezTombElemeit(szamok));
            Console.WriteLine(m.OsszegezTombElemeit(szamok2));
            //string[] nev = { "Bence", "Áprád" };
            //OsszegezTombElemeit(nev);

            // ÁTLAG TÉTEL FÜGGVÉNYBE HÁZI FELADAT

            // proceduriláisan kódold le!
            // rakd ki függvénybe
            // rakd át a matek osdztályba
            Console.ReadKey();
        }
    }
}
