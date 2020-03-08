using Forma1.myexeption;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    class Racer
    {
        private int id;
        private string name;
        private int age;
        private int salary;

        public Racer(int id, string name, int age,int salary)
        {
            NameValidator nv = new NameValidator(name);
            try
            {
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException)
            {
                throw new RacerException("Versenyző neve üres!");
            }            
            catch( NameNotValidFirstLetterProblemException)
            {
                throw new  RacerException("Versenyző neve nagy betűvel kell kezdődjön!");
            }
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public int getSalary()
        {
            return salary;
        }

        public int getID()
        {
            return id;
        }

        public void update(Racer racer)
        {
            this.id = racer.getID();
            this.name = racer.getName();
            this.age = racer.getAge();
            this.salary = racer.getSalary();
        }

        public override string ToString()
        {
            return id+",  "+name+" "+age+" éves és fizetése"+salary;
        }
    }
}
