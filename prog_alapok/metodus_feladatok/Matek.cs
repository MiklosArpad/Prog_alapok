using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodus_feladatok
{
    public class Matek
    {
        /// <summary>
        /// Ez a függvény összegez egy tömb elemeit
        /// </summary>
        /// <param name="kismacska">Tömb</param>
        /// <returns>Visszaadja a tömb elemeinek összegét</returns>
        //public int OsszegezTombElemeit(int[] kismacska) // paraméter blokktól blokkig él
        //{
        //    int osszeg = 0;

        //    foreach (int szam in kismacska)
        //    {
        //        osszeg += szam;
        //    }

        //    return osszeg;
        //}

        // IDE AZ ÁTLAG TÉTEL
        public double AtlagoldJegyeket(int[] jegyek)
        {
            int osszeg = 0;

            foreach (int jegy in jegyek)
            {
                osszeg += jegy;
            }

            int darab = jegyek.Length;
            double vegerdemeny = (double)osszeg / darab;

            return vegerdemeny;
        }
    }
}
