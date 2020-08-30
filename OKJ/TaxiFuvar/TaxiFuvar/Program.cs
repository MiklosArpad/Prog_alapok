using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiFuvar
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Fuvar> fuvarLista = new List<Fuvar>();
            var sorok = File.ReadAllLines("../../fuvar.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (string sor in sorok)
            {
                string[] adatok = sor.Split(';');

                Fuvar fuvar = new Fuvar();

                fuvar.taxiId = Convert.ToInt32(adatok[0]);
                fuvar.indulas = adatok[1];
                fuvar.idotartam = Convert.ToInt32(adatok[2]);
                fuvar.tavolsag = Convert.ToDouble(adatok[3]);
                fuvar.viteldij = Convert.ToDouble(adatok[4]);
                fuvar.borravalo = Convert.ToDouble(adatok[5]);
                fuvar.fizetesModja = adatok[6];

                fuvarLista.Add(fuvar);
            }

            Console.WriteLine($"3. feladat: {fuvarLista.Count} fuvar");

            int fuvarDarab = 0;
            double osszesBevetel = 0;

            foreach (Fuvar f in fuvarLista)
            {
                if (f.taxiId == 6185)
                {
                    osszesBevetel += (f.viteldij + f.borravalo);
                    fuvarDarab++;
                }
            }

            Console.WriteLine($"4. feladat: {fuvarDarab} fuvar alatt: {osszesBevetel}$");

            //5.

            Dictionary<string, int> fizetesiModokDarabjainakSzotara = new Dictionary<string, int>();

            foreach (Fuvar f in fuvarLista)
            {
                if (fizetesiModokDarabjainakSzotara.ContainsKey(f.fizetesModja))
                {
                    fizetesiModokDarabjainakSzotara[f.fizetesModja]++;
                }
                else
                {
                    fizetesiModokDarabjainakSzotara.Add(f.fizetesModja, 1);
                }
            }

            // a foreach már végigjárta a lista összes fuvarját és csoportosította darabonként a fizetési módokat


            Console.WriteLine("5. feladat: ");

            foreach (KeyValuePair<string, int> fizetesiModokDarabjai in fizetesiModokDarabjainakSzotara)
            {
                Console.WriteLine($"\t{fizetesiModokDarabjai.Key}: {fizetesiModokDarabjai.Value} fuvar");
            }

            //6.

            double osszesTavolsag = 0;

            foreach (Fuvar f in fuvarLista)
            {
                osszesTavolsag += f.tavolsag * 1.6;
            }
            Console.WriteLine($" 6. feladat: {osszesTavolsag.ToString("0.00")}km");

            //7.:

            double max = 0;
            Fuvar leghosszabbFuvar = null;

            foreach (Fuvar f in fuvarLista)
            {
                if (f.idotartam > max)
                {
                    max = f.idotartam;
                    leghosszabbFuvar = f;
                }
            }

            Console.WriteLine("7. feladat: Leghosszabb fuvar:");
            Console.WriteLine($"\tFuvar hossza: {leghosszabbFuvar.idotartam} másodperc");
            Console.WriteLine($"\tTaxi azonosító: {leghosszabbFuvar.taxiId}");
            Console.WriteLine($"\tMegtett távolság: {leghosszabbFuvar.tavolsag} mérföld");
            Console.WriteLine($"\tViteldíj: {leghosszabbFuvar.viteldij}$");

            //8.

            string tartalom = "taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja\n";

            foreach (var f in fuvarLista)
            {
                if (f.idotartam > 0 && f.viteldij > 0 && f.tavolsag == 0)
                {
                    tartalom += f.ToString() + "\n";
                }
            }

            File.WriteAllText("../../hibak.txt", tartalom, Encoding.UTF8);

            Console.ReadKey();
        }
    }
}
