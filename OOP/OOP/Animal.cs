using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Animal // KÉKSZÍNŰ TERVRAJZ
    {
        /* ADATTAGOK */
        public string name; // null
        public int age; // 0
        public int weight; // 0

        /* KONSTRUKTOR */
        //public Animal(string name, int age, int suly)
        //{
        //    this.name = name; // Animal class 'name' adattagja legyen egyenlő a paraméterül kapott 'name' váltzó értékével
        //    this.age = age;
        //    this.weight = suly;
        //}

        public Animal()
        {

        }

        /* TAGMETÓDUSOK */

        public override string ToString()
        {
            return "Az állat neve: " + name + ", életkora: " + age + " és a súlya: " + weight;
        }
    }
}
