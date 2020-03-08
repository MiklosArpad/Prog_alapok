using System;
using System.Collections.Generic;
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
        /// <exception cref="">Két úgyan olyan versenyző nem lehet</exception>
        public void addRacer(Racer r)
        {
            racers.Add(r);
        }        

        /// <summary>
        /// Törli a versenyzőt a csapatból
        /// </summary>
        /// <param name="name">Törlendő versenyző neve</param>
        /// <exception cref="">A versenyző a csapatnak nem tagja, nem lehet törlni</exception>
        public void deleteRacer(string name, int age)
        {
            int index = 0;
            foreach (Racer r in racers)
            {
                if (r.getName() == name && r.getAge()==age)
                {
                    racers.RemoveAt(index);
                    return;
                }
                index = index + 1;
            }
            throw new TeamException(name + " versenyző a csapatnak nem tagja, nem lehet törlni");
        }

        /// <summary>
        /// Módosítja a versenyző adatait
        /// </summary>
        /// <param name="name">Módosítanidó versenyző</param>
        /// <param name="newRacer">A módosított versenyző adatai</param>
        /// <exception cref="">A módosítandó versenyzőt nem találjuk, nem lehet módosítani</exception>
        public void updateRacer(string name, Racer newRacer)
        {
            int index = 0;
            foreach (Racer r in racers)
            {
                if (r.getName() == name)
                {
                    r.update(newRacer);
                    return;
                }
                index = index + 1;
            }
            throw new Exception(name + " módosítandó versenyzőt nem találjuk, nem lehet módosítani");
        }

        /// <summary>
        /// Megadja a csapatban lévő versenyzők számát
        /// </summary>
        /// <returns>Csapatban lévő versenyzők száma</returns>
        public int getNumberOfRacers()
        {
            return racers.Count;
        }       

        /// <summary>
        /// Megkeresi az adott nevű versenyzőt
        /// </summary>
        /// <param name="racerName"></param>
        /// <returns>Ha van, akkor a versenyző, ha nincs akkor null</returns>
        public Racer serchRacerByName(string racerName)
        {
            foreach (Racer r in racers)
                if (r.getName() == racerName)
                    return r;
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
            Racer r = serchRacerByName(racerName);
            if (r != null)
                if (r.getAge() == racerAge)
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
                    return r.getID();
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
                if (r.getID() > maxRacerId)
                    maxRacerId = r.getID();
            return maxRacerId;
        }
    }
}
