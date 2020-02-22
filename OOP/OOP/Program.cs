using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* NÉVTÉR */
namespace OOP
{
    /* OSZTÁLY */
    public class Program
    {
        /* ADATTAGOK */

        /* TAGMETÓDUSOK */
        public static void Main(string[] args)
        {
            // változó = típus + azonosító (név)
            //Animal a = new Animal(); // objektum példányosítás, referencia-típusok
            // a változó össze van kötve egy új Animal típusú objektummal a memóriában

            // KONSTRUKTOR: inicializálja az adattagokat, a referenciaváltozhoz kössön egy objektumot a memóriából
            // KONSTRUKTORNAK NINCS VISSZATÉRÉSI ÉRTÉKE SEMMILYEN ESETBEN!!
            // KONSTRUKTORBÓL BÁRMENNYI LEHET, DE NEM LEHET UGYANAZ A PARAMÉTEREZÉSE (TÍPUS ÉS A SORRENDJÜK)!!!
            // A neve meg kell egyezzen az osztály nevével!
            // 1) HA alapból NEM írok a POJO-mba konstruktort, akkor
            // a fordító csinál egy üreset!!!
            // 2) Írhatok üreset én is, de az redundáns, mert a fordító amúgyis csinál üreset
            // 3) Ha felparaméterezem a konstruktort, akkor MÁR csak azt használhatom,
            // megszűnik a fordító létrehozott üres konstruktor!
            // 4) Megmarad a paraméteres konsturktor, DE szükségem van egy üresre:
            // akkor lazán írok egy üreset:)



            /* Animal objektum példányosítás */
            Animal bodri = new Animal();

            /* beállítjuk (SET) az adattagjait bodrinak */
            bodri.name = "Bodri";
            bodri.age = 12;
            bodri.weight = 130;

            /* Animal objektum példányosítás */
            Animal foxi = new Animal();

            /* beállítjuk (SET) az adattagjait foxinak */
            foxi.name = "Foxi";
            foxi.age = 10;
            foxi.weight = 100;

            /* kiíratjuk az objektumainkat */
            Console.WriteLine(bodri);
            Console.WriteLine(foxi);






            /* MINDIG A KONSTRUKTOR FUT LE ELŐSZÖR, MINT TAGMETÓDUS */
            //Animal foxi = new Animal("Foxi", 12, 130);


            Console.ReadKey();
        }
    }
}
