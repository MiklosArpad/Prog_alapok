using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tobbagu_elagazas
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int szam = Convert.ToInt32(Console.ReadLine()); // Szám bekérés

            if (szam == 0)
            {
                Console.WriteLine("A bekért szám nulla");
            }
            else if (szam == 1)
            {
                Console.WriteLine("A bekért szám egy");
            }
            else if (szam == 2)
            {
                Console.WriteLine("A bekért szám kettő");
            }
            else if (szam==100)
            {
                Console.WriteLine("A bekért száz");
            }
            else
            {
                Console.WriteLine("A bekért szám nem nulla, nem egy és nem is kettő!");
            }

            Console.ReadKey();
        }
    }
}
