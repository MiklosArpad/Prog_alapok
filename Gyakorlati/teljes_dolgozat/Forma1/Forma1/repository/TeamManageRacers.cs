using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class Team : ITeamManageRacers
    {
        /// <summary>
        /// Új versenyző hozzáadása
        /// </summary>
        /// <param name="r">új versenyző</param>
        /// <exception cref="TeamException">Két úgyan olyan versenyző nem lehet</exception>
        public void addRacer(Racer r)
        {
            foreach (Racer racer in racers)
            {
                if (racer.getId() == r.getId() &&
                    racer.getName() == r.getName() &&
                    racer.getSalary() == r.getSalary() &&
                    racer.getAge() == r.getAge())
                {
                    Debug.WriteLine("Van már ilyen versenyző");
                    throw new TeamException("Van már ilyen versenyző");
                }
            }

            racers.Add(r);
        }

        /// <summary>
        /// Törli a versenyzőt a csapatból
        /// </summary>
        /// <param name="name">Törlendő versenyző neve</param>
        /// <param name="age">Törlendő versenyző életkora</param>
        /// <exception cref="TeamException">A versenyző a csapatnak nem tagja, nem lehet törlni</exception>
        public void deleteRacer(string name, int age)
        {
            foreach(Racer racer in racers)
            {
                if (racer.getName() == name && racer.getAge() == age)
                    racers.Remove(racer);
                    return;
            }
            throw new TeamException("A versenyző a csapatnak nem tagja, nem lehet törlni");


            //int index = 0;

            //foreach (Racer racer in racers)
            //{
            //    if (racer.getName() == name && racer.getAge() == age)
            //    {
            //        racers.RemoveAt(index);
            //        return;
            //    }
            //    index++;
            //}
            //throw new TeamException("A versenyző a csapatnak nem tagja, nem lehet törlni");

        }

        /// <summary>
        /// Módosítja a versenyző adatait
        /// </summary>
        /// <param name="name">Módosítanidó versenyző</param>
        /// <param name="newRacer">A módosított versenyző adatai</param>
        /// <exception cref="">A módosítandó versenyzőt nem találjuk, nem lehet módosítani</exception>
        public void updateRacer(string name, Racer newRacer)
        {       
            foreach (Racer racer in racers)
            {
                if (racer.getName()== name)
                {
                    racer.update(newRacer);
                    return;
                }
            }
            throw new RacerException("A módosítandó versenyzőt nem találjuk, nem lehet módosítani");
        }

        /// <summary>
        /// Megadja a csapatban lévő versenyzők számát
        /// </summary>
        /// <returns>Csapatban lévő versenyzők száma</returns>
        public int getNumberOfRacers()
        {
            return racers.Count();     
        }

        /// <summary>
        /// Megkeresi az adott nevű versenyzőt
        /// </summary>
        /// <param name="racerName"></param>
        /// <returns>Ha van, akkor a versenyző, ha nincs akkor null</returns>
        public Racer serchRacerByName(string racerName)
        {
            foreach (Racer racer in racers)
            {
                if (racer.getName() == racerName)
                    return racer;
            }
            return null;
        }

        /// <summary>
        /// Megadja, hogy a versenyző lézetik-e
        /// </summary>
        /// <param name="racerName">Versenyző neve</param>
        /// <param name="racerAge">Versenyző életkora</param>
        /// <returns>Ha létezik, akkor true, ha nem akkor false</returns>
        public bool isRacerExist(string racerName, int racerAge)
        {
            foreach (Racer racer in racers)
                if (racer.getName() == racerName && racer.getAge() == racerAge)
                    return true;
            return false;
        }
        
        /// <summary>
        /// Megadja az adott nevű versenyző azonosítóját
        /// </summary>
        /// <param name="racerName">Versenyző neve</param>
        /// <returns>A versenyző azonosítója</returns>
        public int getRacerId(string racerName)
        {
            foreach (Racer r in racers)
                if (r.getName() == racerName)
                    return r.getId();
            return -1;
        }

        /// <summary>
        /// Megahtározza a legnagyobb azonosítójú versenyző azonosítóját
        /// </summary>
        /// <returns>A legnagyobb azonosító</returns>
        public int getMaxId()
        {
            int maxRacerId = -1;
            foreach (Racer r in racers)
                if (r.getId() > maxRacerId)
                    maxRacerId = r.getId();
            return maxRacerId;
        }
    }
}
