using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Mikor még kódolunk az forditás idő (compiler-time)
            // Mikor fut a program az futásidő (runtime)

            // Vezerlési szerkezetek:
            // 1) Szekvencia: sorba fut a program

            // 2) Elágazás

            int elsoSzam = Convert.ToInt32(Console.ReadLine());

            if (elsoSzam > 0) // logikai kiértékelés
            {
                // Igaz ág
                Console.WriteLine("A bekért szám nagyobb nullánál!");
            }
            else
            {
                // Hamis ág
                Console.WriteLine("A bekért szám nem nagyobb nullánál");
            }

            Console.ReadKey();
        }
    }
}
