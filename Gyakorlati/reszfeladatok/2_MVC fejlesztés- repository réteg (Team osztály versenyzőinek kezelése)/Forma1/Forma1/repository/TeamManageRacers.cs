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
        /// A csapat versenyzőinek listáját adja vissza
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        public List<Racer> getRacers()
        {
            return racers;
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
        /// Új versenyző hozzáadása
        /// </summary>
        /// <param name="r">új versenyző</param>
        /// <exception cref="TeamException">Két úgyan olyan versenyző nem lehet a csapatban</exception>
        public void addRacer(Racer r)
        {
            foreach (Racer racer in racers)
            {
                // MINDEN EGYEZEIK
                if (racer.getId() == r.getId() && racer.getName() == r.getName() && racer.getAge() == r.getAge() && racer.getSalary() == r.getSalary())
                {
                    throw new TeamException("Két úgyan olyan versenyző nem lehet a csapatban");
                }
            }

            racers.Add(r);

            //foreach (Racer racer in racers)
            //{
            //    // MINDEN EGYEZEIK
            //    if (racer.getId() != r.getId() && racer.getName() != r.getName() && racer.getAge() != r.getAge() && racer.getSalary() != r.getSalary())
            //    {
            //        racers.Add(r);
            //        return;
            //    }
            //}
            //throw new TeamException("Két úgyan olyan versenyző nem lehet a csapatban");
        }


        /// <summary>
        /// Törli a versenyzőt a csapatból
        /// Akkor törölje a versenyzőt, ha a neve és a születési éve megegyezik a keresettel
        /// </summary>
        /// <param name="name">Törlendő versenyző neve</param>
        /// <exception cref="TeamException">Ha a versenyző a csapatnak nem tagja, nem lehet törlni</exception>
        public void deleteRacer(string name, int age)
        {
            foreach (Racer racer in racers)
            {
                if (racer.getName() == name && racer.getAge() == age)
                {
                    racers.Remove(racer);
                    return;
                }
            }

            throw new TeamException("Nincs ilyen versenyző!");
        }

        /// <summary>
        /// Módosítja a versenyző adatait
        /// </summary>
        /// <param name="name">Módosítanidó versenyző</param>
        /// <param name="newRacer">A versenyző új adatai</param>
        /// <exception cref="TeamException">Ha a módosítandó versenyzőt nem találjuk, nem lehet módosítani</exception>
        public void updateRacer(string name, Racer newRacer)
        {
            foreach (Racer racer in racers)
            {
                if (racer.getName() == name)
                {
                    racer.update(newRacer);
                    return;
                }
            }

            throw new TeamException("Nincs ilyen nevű versenyző!");
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
                {
                    return racer;
                }
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
            {
                if (racer.getName() == racerName && racer.getAge() == racerAge)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Megadja az adott nevű versenyző azonosítóját
        /// </summary>
        /// <param name="racerName">Versenyző neve</param>
        /// <returns>A versenyző azonosítója</returns>
        public int getRacerId(string racerName)
        {
            foreach (Racer racer in racers)
            {
                if (racer.getName() == racerName)
                {
                    return racer.getId();
                }
            }

            return 0;
        }

        /// <summary>
        /// Megahtározza a legnagyobb azonosítójú versenyző azonosítóját
        /// </summary>
        /// <returns>A legnagyobb azonosító</returns>
        public int getMaxId()
        {
            int maxID = 0;

            foreach (Racer racer in racers)
            {
                if (maxID < racer.getId())
                {
                    maxID = racer.getId();
                }
            }

            return maxID;

            //racers.Max(x => x.getId()); lambda
        }
    }
}
