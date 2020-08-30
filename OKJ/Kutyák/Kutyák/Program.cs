using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyák
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<KutyaNev> kutyaNevek = new List<KutyaNev>();

            var kutyaNevekSorok = File.ReadAllLines("../../KutyaNevek.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (string sor in kutyaNevekSorok)
            {
                var adatok = sor.Split(';');

                KutyaNev kutyaNev = new KutyaNev();

                kutyaNev.id = Convert.ToInt32(adatok[0]);
                kutyaNev.kutyanev = adatok[1];

                kutyaNevek.Add(kutyaNev);
            }

            // 3. feladat: Hány kutyanév található az állományban, írassa ki!

            int kutyaNevSzam = kutyaNevek.Count;
            Console.WriteLine($"3. feladat: Kutyanevek száma: {kutyaNevSzam}");

            // 4. feladat:

            List<KutyaFajta> kutyaFajtak = new List<KutyaFajta>();

            var kutyaFajtakSorok = File.ReadAllLines("../../KutyaFajtak.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (string sor in kutyaFajtakSorok)
            {
                var adatok = sor.Split(';');

                KutyaFajta kutyaFajta = new KutyaFajta();

                kutyaFajta.id = Convert.ToInt32(adatok[0]);
                kutyaFajta.nev = adatok[1];
                kutyaFajta.eredetiNev = adatok[2];

                kutyaFajtak.Add(kutyaFajta);

            }

            // 5. feladat:

            List<Kutya> kutyak = new List<Kutya>();

            var kutyaSorok = File.ReadAllLines("../../Kutyak.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (string sor in kutyaSorok)
            {
                var adatok = sor.Split(';');

                Kutya kutya = new Kutya();

                kutya.id = Convert.ToInt32(adatok[0]);
                kutya.fajtaId = Convert.ToInt32(adatok[1]);
                kutya.nevId = Convert.ToInt32(adatok[2]);
                kutya.eletkor = Convert.ToInt32(adatok[3]);
                kutya.utolsoOrvosiEllenorzes = adatok[4];

                kutyak.Add(kutya);
            }

            //6.feladat:

            // a kutyák életkorának összege

            int osszeg = 0;
            int kutyakSzama = kutyak.Count;

            foreach (Kutya k in kutyak)
            {
                osszeg += k.eletkor;
            }

            // itt már tudjuk az össze skutya életkorának az összegét!

            double atlag = (double)osszeg / kutyakSzama;

            Console.WriteLine($"6. feladat: Kutyák életkorának összege és azok átlagéletkora: {atlag.ToString("0.00")}");

            //7.feladat: A legidősebb kutya

            int max = int.MinValue;
            string nev = "";
            string fajta = "";

            int nevId = 0;
            int fajtaId = 0;

            foreach (Kutya k in kutyak)
            {
                if (k.eletkor > max)
                {
                    max = k.eletkor;
                    nevId = k.nevId;
                    fajtaId = k.fajtaId;
                }
            }

            foreach (KutyaNev kutyaNev in kutyaNevek)
            {
                if (nevId == kutyaNev.id)
                {
                    nev = kutyaNev.kutyanev;
                }
            }

            foreach (KutyaFajta kutyaFajta in kutyaFajtak)
            {
                if (fajtaId == kutyaFajta.id)
                {
                    fajta = kutyaFajta.nev;
                }

            }

            Console.WriteLine(max + " " + nev + " " + fajta);


            //8.feladat:

            Dictionary<int, int> db = new Dictionary<int, int>();

            foreach (var k in kutyak)
            {
                if (k.utolsoOrvosiEllenorzes == "2018.01.10")
                {
                    if (db.ContainsKey(k.fajtaId))
                    {
                        db[k.fajtaId]++;
                    }
                    else
                    {
                        db.Add(k.fajtaId, 1);
                    }
                }
            }

            foreach (var f in db)
            {
                foreach (KutyaFajta kf in kutyaFajtak)
                {
                    if (f.Key == kf.id)
                    {
                        Console.WriteLine(kf.nev + " " + f.Value + " kutya");
                    }
                }
            }


            //9.feladat: 

            //10.


            Console.ReadKey();
        }
    }
}
