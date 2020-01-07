using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valtozok
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ide írjunk mindig, a fordító a Main metódust keresni...

            // változó miből áll? típusl (pl. int) és egyedi névből (azonosító)
            // Deklarálás: pl. int szam;
            // Inicializálás: int szam = 1;

            // Érték típusok:

            // 32 bites szám -2147483648 to 2147483647
            int szam = 2143647;

            // karakter típus
            char valamiKarakter = 'd';

            // 32 bites tizedesszám
            float f = 1.3f;

            // 64 bites tizedesszám
            double d = 1.3;

            // logikai típus, true vagy false értékeket lehet neki adni
            bool igazE = false;

            // 64 bites szám
            long i = 2345435355353443;

            // String: objektum (referenciatípus)
            string valami = "Ez egy karakterlánc"; // string valami = new string();







            // Szám típusok------------------------------------

            sbyte sbajt = -128;// -128 to 127
            byte bajt = 255; // 0 to 255
            short sort = -32768; // -32768 to 32767
            ushort usort = 0; // 0 to 65535;
            uint uinteger = 200000; // 0 to 4294967295

        }
    }
}
