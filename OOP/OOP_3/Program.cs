using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* NÉVTÉR */
namespace OOP_3
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

            bodri.Name = "Bodri";
            bodri.Age = 12;
            bodri.Weight = -130;


            /* kiíratjuk az objektumainkat */
            Console.WriteLine(bodri);

            bodri.teszt();

            Animal newAnimal = new Animal();
            newAnimal.teszt();

            Console.ReadKey();
        }
    }
}
