using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodik_dia
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) feladat
            /* Írj programot, amelyben bekérsz a, b és c egész szám élhosszúságú téglatestnek kiszámolja a térfogatát és a felszínét!
            Segítség: a paraméterként kapott szöveges típusú értéket.*/

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            // Térfogat + felszín , V = a*b*c A= 2(a*b+b*c+a*c)

            //int A = 2 * (a * b + b * c + a * c);
            //int V = a * b * c;

            // Kiíráatás:

            //Console.WriteLine("A téglatest térfogata: " + V);
            //Console.WriteLine("A téglatest felszíne: " + A);

            /* 2) feladat Írj programot, amely a BEKÉRÉS adott 2 számnak kiírja az összegét,
            különbségét, szorzatát és hányadosát! */

            //Console.WriteLine("Add meg az első számot!");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Add meg a második számot!");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("A két szám összege " + (a + b));
            //Console.WriteLine("A két szám különbsége " + (a - b));
            //Console.WriteLine("A két szám szorzata " + (a * b));
            //Console.WriteLine("A két szám hányados " + (a / b));

            /* 3) feladat Írj programot, amely a paraméterként adott 5 számnak kiírja a számtani
közepét! */

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int e = Convert.ToInt32(Console.ReadLine());

            //double A = (double)(a + b + c + d + e) / 5;

            //Console.WriteLine($"Számtani közép: {A}");

            /* 4) feladat Írj másodfokú egyenletet megoldó programot! BEKÉRÉS megkapjuk az
a, b és c együtthatók értékét (egész számok), és írjuk ki az egyenlet két
megoldását!
Segítség: Gyökvonáshoz a Math.sqrt() metódust használd! A
diszkrimináns gyökét double típusú változóban tárold!*/

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //// x1,2=-b+-GYÖK(b négyzet - 4ac) / 2a

            //// b négyzete= b*b, Math.Pow(b, 2);
            //double diszkriminansGyoke = Math.Sqrt(b * b - 4 * a * c);

            //double elsoMegoldas = (-b + diszkriminansGyoke) / 2 * a;
            //double masodikMegoldas = (-b - diszkriminansGyoke) / 2 * a;


            /* + feladat Kerület, Terület K = 4*a, T=a*a  */

            //int a = Convert.ToInt32(Console.ReadLine());

            //int K = 4 * a;
            //int T = a * a;

            //Console.WriteLine($"A négyzet kerülete {K}");
            //Console.WriteLine($"A négyzet Területe {T}");

            /* téglalap K+T*/

            Console.Write("Adja meg az A oldalt: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az B oldalt: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int K = 2 * (a + b);              // 2*a + 2*b
            int T = a * b;


            Console.WriteLine($"A téglalap kerülete {K}");
            

            Console.WriteLine($"A téglalap Területe {T}");


            Console.ReadLine();
        }
    }
}
