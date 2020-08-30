using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatSzerkezetek
{
    class No
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public string Hajszin { get; set; }
        public double Suly { get; set; }

        public No(string nev, int eletkor, string hajszin, double suly)
        {
            Nev = nev;
            Eletkor = eletkor;
            Hajszin = hajszin;
            Suly = suly;
        }

        public No()
        {

        }

        public override string ToString()
        {
            return $"{Nev} {Eletkor} {Hajszin} {Suly}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<No> nok = new List<No>();

            nok.Add(new No { Nev = "Ági", Eletkor = 18, Hajszin = "szőke", Suly = 78 });
            nok.Add(new No { Nev = "Borbála", Eletkor = 28, Hajszin = "szőke", Suly = 100 });
            nok.Add(new No { Nev = "Csenge", Eletkor = 33, Hajszin = "barna", Suly = 58 });
            nok.Add(new No { Nev = "Klaudia", Eletkor = 68, Hajszin = "ősz", Suly = 74 });
            nok.Add(new No { Nev = "Rozi", Eletkor = 55, Hajszin = "ősz", Suly = 61 });
            nok.Add(new No { Nev = "Viki", Eletkor = 42, Hajszin = "vörös", Suly = 65 });

            // Lista metódusok

            //1) Add -> hozzáad a listához az utolsó helyre egy újabb elemet
            //nok.Add(new No("Hajni", 13, "szőke", 63));

            // 2) Remove -> töröl valamilyen elemet
            // minden adattagja ugyanaz

            // 3) RemoveAt -> index alapján töröl
            // indexről töröl

            // 4) RemoveAll -> összes olyan elemet törli a listából, ami a feltételnek megfelel
            // ugyanolyan feltételű nőket töröl
            //nok.RemoveAll(no => no.Nev == "Ági"); // összes Ági nevűt törli
            //nok.RemoveAll(no => no.Eletkor > 20); // összes 20 fölötti életkorú nőt töröl
            //nok.RemoveAll(no => no.Suly < 50); // aki 50 kgnál soványabb azt törli
            //nok.RemoveAll(no => no.Hajszin == "ősz"); // összes ősz hajú nőt törli a listából

            // 5) Contains -> bool függvény: eldönti van e adott elem a listában. Ha van akkor true, ha nem akkor false
            //foreach (No no in nok)
            //{
            //    if (no.Nev.Contains("á"))
            //    {
            //        // 
            //    }
            //}

            // 6) Exists -> létezik-e valamilyen szám adott feltételre
            //nok.Exists(no => no.Hajszin == "ősz"); // true -> van őszhajú nő
            //nok.Exists(no => no.Nev == "Ági"); // van-e Ági nevű nő?
            //nok.Exists(no => no.Eletkor < 20); // van-e olyan nő akinek az életkora nagyobb 20-nál
            //nok.Exists(no => no.Suly < 50); // van-e olyan nő aki soványabb 50 kgnál

            //// 7) FindAll metódus -> a feltétel teljeseülése esetén kigyűjti az objketumokat egy listába
            //List<No> szokeNok = nok.FindAll(no => no.Hajszin == "szőke");

            //szokeNok.ForEach(Console.WriteLine);


            // 8) Find -> keressük meg azt a nőt, akinek Ági a neve
            //No agi = nok.Find(no => no.Nev == "Ági");

            // 9) Count -> visszaadja a lista hosszát
            //int nokSzama = nok.Count; // 6

            // prog tételek röviden:

            // 1) összegzés tétel: csak számra működik!

            // összes nő életkorát adjuk össze
            int sumEletkor = nok.Sum(no => no.Eletkor);
            double sumSuly = nok.Sum(no => no.Suly);

            Console.WriteLine($" A nők életkora összesen: {sumEletkor}");
            Console.WriteLine(sumSuly);

            List<int> szamok = new List<int>() { 1, 2, 3, 4, 5 };
            szamok.Sum();

            // Sum()
            //int sum = 0;
            //foreach (var szam in szamok)
            //{
            //    sum += szam;
            //}

            // 2) megszámlálás tétel: Hány darab szőke van a listában?
            int szokenokDb = nok.Count(no => no.Hajszin == "szőke");
            Console.WriteLine($"szőke nők száma: {szokenokDb}");

            // Hány darab vörös nő van?
            int vorosnoDb = nok.Count(no => no.Hajszin == "vörös");
            Console.WriteLine($"vörös nők száma: {vorosnoDb}");

            // Hány darab nő van aki fiatalabb 50-nél?
            int idosnoDb = nok.Count(no => no.Eletkor < 50);
            Console.WriteLine($"az 50-nél fiatalabb nők száma: {idosnoDb}");

            // Hány darab nő van aki idősebb 20-nál?
            int fiatalnoDb = nok.Count(no => no.Eletkor > 20);
            Console.WriteLine($"az 20-nál idősebb nők száma: {fiatalnoDb}");

            // Hány darab nő van, aki 50kgnál nehezebb de 70 kgnál könnyebb?
            int db50nelNehezebbDe70nelKonyebbNok = nok.Count(x => x.Suly > 50 && x.Suly < 70);
            Console.WriteLine(db50nelNehezebbDe70nelKonyebbNok);

            // Átlag tétel

            // mennyi a nők átlagéletkora?
            // mennyi a nők átlag testsúlya?

            double atlageletkor = nok.Average(x => x.Eletkor);
            double atlagtestsuly = nok.Average(x => x.Suly);

            Console.WriteLine(atlageletkor);
            Console.WriteLine(atlagtestsuly);

            // Maximum

            // melyik a legnagyobb testsúly?
            // melyik a legnagyobb életkor?

            double maxSuly = nok.Max(x => x.Suly);
            int maxEletkor = nok.Max(x => x.Eletkor);

            // Minimum

            // melyik a legkisebb testsúly?
            // melyik a legkisebb életkor?

            double minSuly = nok.Min(x => x.Suly);
            int minEletkor= nok.Min(x => x.Eletkor);


            Console.WriteLine(maxSuly);
            Console.WriteLine(maxEletkor);
            Console.WriteLine(minSuly);
            Console.WriteLine(minEletkor);


            No legisebbNo = nok.Find(x => x.Eletkor == nok.Max(y => y.Eletkor));
            Console.WriteLine(legisebbNo.Nev);

            //var legidosebbNo = from No n in nok
            //                   where n.Eletkor == 50
            //                   select n;

            // csortosítsuk a  nőket hajszín szerint, pl. vörösből hány darab van, szőkéből, stb...
            Dictionary<string, int> szotar = new Dictionary<string, int>();

            foreach (No x in nok)
            {
                if (szotar.ContainsKey(x.Hajszin))
                {
                    szotar[x.Hajszin]++;
                }
                else
                {
                    szotar.Add(x.Hajszin, 1);
                }
            }

            foreach (var item in szotar)
            {
                Console.WriteLine($"Hajszín: {item.Key}\t{item.Value} db");
            }


            Console.ReadKey();

        }
    }
}