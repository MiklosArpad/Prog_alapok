using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Nyelvvizsga> sikeres = new List<Nyelvvizsga>();
            List<Nyelvvizsga> sikertelen = new List<Nyelvvizsga>();

            // Házi feladat:

            List<string> sikeresSorok = File.ReadAllLines("../../sikeres.csv", Encoding.UTF8).Skip(1).ToList();
            List<string> sikerestelenSorok = File.ReadAllLines("../../sikertelen.csv", Encoding.UTF8).Skip(1).ToList();

            foreach (string sikeresSor in sikeresSorok)
            {
                string[] sikeresAdatok = sikeresSor.Split(';');

                Nyelvvizsga nyv = new Nyelvvizsga();

                nyv.Nyelv = sikeresAdatok[0];
                nyv.Darab2009 = Convert.ToInt32(sikeresAdatok[1]);
                nyv.Darab2010 = Convert.ToInt32(sikeresAdatok[2]);
                nyv.Darab2011 = Convert.ToInt32(sikeresAdatok[3]);
                nyv.Darab2012 = Convert.ToInt32(sikeresAdatok[4]);
                nyv.Darab2013 = Convert.ToInt32(sikeresAdatok[5]);
                nyv.Darab2014 = Convert.ToInt32(sikeresAdatok[6]);
                nyv.Darab2015 = Convert.ToInt32(sikeresAdatok[7]);
                nyv.Darab2016 = Convert.ToInt32(sikeresAdatok[8]);
                nyv.Darab2017 = Convert.ToInt32(sikeresAdatok[9]);

                sikeres.Add(nyv);
            }

            foreach (string sikertelenSor in sikerestelenSorok)
            {
                string[] sikertelenAdatok = sikertelenSor.Split(';');

                Nyelvvizsga nyv = new Nyelvvizsga();

                nyv.Nyelv = sikertelenAdatok[0];

                nyv.Nyelv = sikertelenAdatok[0];
                nyv.Darab2009 = Convert.ToInt32(sikertelenAdatok[1]);
                nyv.Darab2010 = Convert.ToInt32(sikertelenAdatok[2]);
                nyv.Darab2011 = Convert.ToInt32(sikertelenAdatok[3]);
                nyv.Darab2012 = Convert.ToInt32(sikertelenAdatok[4]);
                nyv.Darab2013 = Convert.ToInt32(sikertelenAdatok[5]);
                nyv.Darab2014 = Convert.ToInt32(sikertelenAdatok[6]);
                nyv.Darab2015 = Convert.ToInt32(sikertelenAdatok[7]);
                nyv.Darab2016 = Convert.ToInt32(sikertelenAdatok[8]);
                nyv.Darab2017 = Convert.ToInt32(sikertelenAdatok[9]);

                sikertelen.Add(nyv);
            }

            Dictionary<string, int> nyelvekNepszerusegeSikeres = new Dictionary<string, int>();

            foreach (Nyelvvizsga nyv in sikeres)
            {
                if (!nyelvekNepszerusegeSikeres.ContainsKey(nyv.Nyelv))
                {
                    nyelvekNepszerusegeSikeres.Add(nyv.Nyelv, nyv.GetNyelvDarabszamaiOsszesEvben);
                }
            }

            Dictionary<string, int> nyelvekNepszerusegeSikertelen = new Dictionary<string, int>();

            foreach (Nyelvvizsga nyv in sikertelen)
            {
                if (!nyelvekNepszerusegeSikertelen.ContainsKey(nyv.Nyelv))
                {
                    nyelvekNepszerusegeSikertelen.Add(nyv.Nyelv, nyv.GetNyelvDarabszamaiOsszesEvben);
                }
            }

            Dictionary<string, int> nyelvvizsgakNepszerusege = new Dictionary<string, int>();

            foreach (var item in nyelvekNepszerusegeSikeres)
            {
                if (nyelvvizsgakNepszerusege.ContainsKey(item.Key))
                {
                    nyelvvizsgakNepszerusege[item.Key] += item.Value;
                }
                else
                {
                    nyelvvizsgakNepszerusege.Add(item.Key, item.Value);
                }
            }

            foreach (var item in nyelvekNepszerusegeSikertelen)
            {
                if (nyelvvizsgakNepszerusege.ContainsKey(item.Key))
                {
                    nyelvvizsgakNepszerusege[item.Key] += item.Value;
                }
                else
                {
                    nyelvvizsgakNepszerusege.Add(item.Key, item.Value);
                }
            }

            var nyelvvizsgaknepszerusegCsokkeno = nyelvvizsgakNepszerusege.OrderByDescending(x => x.Value).Take(3);

            foreach (var item in nyelvvizsgaknepszerusegCsokkeno)
            {
                Console.WriteLine(item.Key);
            }


            Console.ReadKey();
        }
    }
}