using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* NÉVTÉR */
namespace OOP_4
{
    /* OSZTÁLY */
    public class Program : Object
    {
        /* ADATTAGOK */

        /* TAGMETÓDUSOK */
        public static void Main(string[] args)
        {
            /* Animal objektum példányosítás */
            Dog kutya = new Dog();

            kutya.Name = "Bodri";
            kutya.Age = 12;
            kutya.Weight = 130;

            /* kiíratjuk az objektumainkat */
            Console.WriteLine(kutya);

            kutya.Ugat();

            Animal bagoly = new Animal();

            Console.ReadKey();
        }
    }
}
