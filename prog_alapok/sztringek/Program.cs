using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztringek
{
    class Program
    {
        static void Main(string[] args)
        {
            // IMMUTABLE TÍPUS -> megváltaztothatatlan

            string nev = "Árpád"; // String nev = new String("Árpád"); ez történik háttérben
            // "Árpád" paraméter = karaktertömb ['Á', 'r', 'p', 'á', 'd']

            // Stringet lehet tömbként kezelni
            // nev[0] -> ez visszaadja a 'Á' (char)
            //Console.WriteLine(nev[5]); // elszáll, nincs 5. indexe a sztringek

            Console.WriteLine(nev.Length); // milyen hosszú a string, output: 5 // visszaadja a karakterlánc (string) hosszát, (hány darab karaktertből áll?)
            Console.WriteLine(nev.ToUpper()); // ÁRPÁD // minden karaktert kicserél nagybetűre
            Console.WriteLine(nev.ToLower()); // árpád // minden karaktert kicserél kisbetűre
            Console.WriteLine(nev.Replace('r', 'l')); // Álpád // ez valamelyik karaktert kicseréli valamely más karakterre
            Console.WriteLine(nev.Replace("Árp", "Rpá")); // Rpáád // ez valamelyik string részletet kicseréli valamely más string részletre
            Console.WriteLine(nev.Substring(0, 3)); // Árp // ez valamelyik indextől valahány darabnyit kidarabol
            Console.WriteLine(nev.IndexOf('r')); // 1 // ez az első előfordulás szerinti karakter indexét (helyét) adja vissza
            Console.WriteLine(nev.ElementAt(3)); // á // ez megadott index pl. 3 alapján visszaadja az ott lévő indexen a karaktert
            //Console.WriteLine(nev.Reverse().ToString()); // dáprÁ // megfordítja a stringet
            Console.WriteLine(nev.Remove(2, 2)); // Árd // 2. indextől kezdve 2 karaktert kivág

            Console.ReadKey();
        }
    }
}
