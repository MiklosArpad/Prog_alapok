using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* NÉVTÉR */
namespace OOP_2
{
    /* OSZTÁLY */
    public class Program : Object
    {
        /* ADATTAGOK */

        /* TAGMETÓDUSOK */
        public static void Main(string[] args)
        {
            /* Animal objektum példányosítás */
            Animal bodri = new Animal();

            /* beállítjuk (SET) az adattagjait bodrinak */
            /* védem az objektum adattagjait, private kulcsszóval*/
            /*közvetlenül nem férek hozzá a példányon/objektumon keresztül*%
            bodri.name = "Bodri";
            bodri.age = 12;
            bodri.weight = 130;*/

            bodri.SetName("Bodri");
            bodri.SetAge(12);
            bodri.SetWeigth(130);

            /* Animal objektum példányosítás */
            Animal foxi = new Animal();

            /* beállítjuk (SET) az adattagjait foxinak */
            foxi.SetName("Foxi");
            foxi.SetAge (10);
            foxi.SetWeigth(100);

            /* GETTELÉS */
            string nev = foxi.GetName(); // "Foxi"
            


            /* kiíratjuk az objektumainkat */
            Console.WriteLine(bodri);
            Console.WriteLine(foxi);

            /* MINDIG A KONSTRUKTOR FUT LE ELŐSZÖR, MINT TAGMETÓDUS */
            //Animal foxi = new Animal("Foxi", 12, 130);

            Console.ReadKey();
        }
    }
}
