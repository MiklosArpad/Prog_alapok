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
        /// <exception cref="TeamException">Két úgyan olyan versenyző nem lehet</exception>
        public void addRacer(Racer r)
        {
        }

        /// <summary>
        /// Törli a versenyzőt a csapatból
        /// </summary>
        /// <param name="name">Törlendő versenyző neve</param>
        /// <param name="age">Törlendő versenyző életkora</param>
        /// <exception cref="TeamException">A versenyző a csapatnak nem tagja, nem lehet törlni</exception>
        public void deleteRacer(string name, int age)
        {
        }

        /// <summary>
        /// Módosítja a versenyző adatait
        /// </summary>
        /// <param name="name">Módosítanidó versenyző</param>
        /// <param name="newRacer">A módosított versenyző adatai</param>
        /// <exception cref="">A módosítandó versenyzőt nem találjuk, nem lehet módosítani</exception>
        public void updateRacer(string name, Racer newRacer)
        {            
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
