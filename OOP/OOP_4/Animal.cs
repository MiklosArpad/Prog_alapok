using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    public class Animal : Object // KÉKSZÍNŰ TERVRAJZ
    {
        protected string name;
        protected int age;
        protected int weight;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Életkor nem lehet mínisz");
                }
                age = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Nem lehet mínusz a súly!");
                }
                weight = value;
            }
        }

        /* TAGMETÓDUSOK */


        public override string ToString()
        {
            return "Az állat neve: " + Name + ", életkora: " + Age + " és a súlya: " + Weight;
        }
    }
}
