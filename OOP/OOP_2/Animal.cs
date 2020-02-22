using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class Animal : Object // KÉKSZÍNŰ TERVRAJZ
    {
        /* ADATTAGOK */
        private string name; // null
        private int age; // 0
        private int weight; // 0

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
        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public int GetWeight()
        {
            return weight;
        }

        public void SetName(string name)
        {
            // THIS KULCSSZÓ AZ OSZTÁLYRA
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetWeigth(int weight)
        {
            if (weight < 0)
            {
                return;
                //throw new Exception("Súly nem lehet mínusz");
            }
            this.weight = weight;
        }
        public override string ToString()
        {
            return "Az állat neve: " + name + ", életkora: " + age + " és a súlya: " + weight;
        }
    }
}
