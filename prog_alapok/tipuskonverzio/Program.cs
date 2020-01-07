using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipuskonverzio
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Össze kell adjam a két számot
            //Console.WriteLine(fajlbolSzam + fajlbolMasikSzam); + jel az string összefuzo operátor is !

            // Aritmetikai
            int szamInt = 12;
            double tizedes = szamInt; // dobule tipusba belefér a 12, de az int is mint tipus!

            //double masikDouble = 12.45;
            //int masikInt = (int)masikDouble; // Castolás. integere hiába fér bele a 12, de a tipousa mint double az már NEM!

            double masikDouble = 12.45;
            int masikInt = Convert.ToInt32(masikDouble);

            // KONVERTÁLÁS


            string fajlbolSzam = "1112";
            string fajlbolMasikSzam = "4445";

            Console.WriteLine(fajlbolSzam + fajlbolMasikSzam); // stringnél a + jel az összefüzés

            int szam1 = Convert.ToInt32(fajlbolSzam); // "12" stringet átkonvertálja integerré
            int szam2 = Convert.ToInt32(fajlbolMasikSzam); // 45-öt átkonvertálja intté stringből

            int osszeg = szam1 + szam2; // Integernél a + jel aritemtikai (összesadás) operátornak veszi

            Console.WriteLine(osszeg);

            Console.ReadKey();
        }
    }
}
