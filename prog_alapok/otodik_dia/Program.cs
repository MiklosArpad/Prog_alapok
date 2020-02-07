using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otodik_dia
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Feladat. Írj programot, amely egész számokat kér be a képernyőről egészen addig,
            //            míg a felhasználó 11 - et nem ad meg! Ezután írd ki, hányadik számként
            //              kaptuk a 11 - est!

            //int a;
            //do
            //{
            //    Console.WriteLine("Adjon meg egy számot!");
            //    a = Convert.ToInt32(Console.ReadLine());
            //} while (a != 11); // true lesz a kiértékelés, akkor újrapörög a ciklus


            //string nev;
            //do
            //{
            //    Console.WriteLine("Adjon meg egy nevet!");
            //    nev = Console.ReadLine();

            //} while (nev != "Árpád");

            //Console.ReadKey();


            //2. Feladat. Írj programot, amely beolvas egy egész számot, és eldönti róla, hogy
            //            osztható - e 2 - vel vagy 3 - mal!

            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam % 3 == 0)
            {
                if (szam % 2 == 0)
                {
                    Console.WriteLine("A szám osztható 2-vel és 3-mal!");
                }
                else
                {
                    Console.WriteLine("A szám osztható 3-mal, de 2-vel nem!");
                }
            }
            else
            {
                if (szam % 2 == 0)
                {
                    Console.WriteLine("A szám osztható 2-vel, de 3-mal nem!");
                }
                else
                {
                    Console.WriteLine("A szám nem oszható sem 2-vel sem 3-mal!");
                }
            }


            Console.ReadKey();
        }
    }
}
