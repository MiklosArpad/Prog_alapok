using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadik_dia
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. FELADAT Írj programot, amely a paraméterben adott számról eldönti és kiírja annak
            //paritását(páros vagy páratlan)!

            //Console.WriteLine("Add meg az első számot!");
            //int a = Convert.ToInt32(Console.ReadLine());

            //if (a % 2 == 0) // a bekért szám ha elosztom 2-vel, akkor 0 lesz-e a maradék...
            //{
            //    Console.WriteLine("A megadott szám páros");
            //}
            //else
            //{
            //    Console.WriteLine("A megadott szám páratlan");
            //}
            //Console.ReadKey();

            //3. FELADAT Írj programot, mely a paraméterként adott háromszög oldalak hosszúsága
            //alapján eldönti, hogy a háromszög szerkeszthető - e!

            //Console.WriteLine("Add meg az első számot!");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Add meg a második számot!");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Add meg a harmadik számot!");
            //int c = Convert.ToInt32(Console.ReadLine());
            //// a<b+c,  b<a+c,   c<a+b
            //// AND: true és false = false
            //// OR: true és false =true
            //if (a < b + c && b < a + c && c < a + b)
            //{
            //    Console.WriteLine("A három szerkeszthető");
            //}
            //else
            //{
            //    Console.WriteLine("A háromszög nem szerkeszthető");
            //}
            //Console.ReadKey();


            //5. FELADAT Írj programot, amely a paraméterként adott két számról eldönti, hogy
            //  melyik a nagyobb!


            Console.WriteLine("Add meg az első számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a második számot!");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("A b nagyobb");
            }
            else
            {
                Console.WriteLine("Az a nagyobb");
            }


            if (a > b)
            {
                Console.WriteLine("Az a nagyobb");
            }
            else
            {
                Console.WriteLine("A b nagyobb");
            }
            Console.ReadKey();

        }
    }
}
