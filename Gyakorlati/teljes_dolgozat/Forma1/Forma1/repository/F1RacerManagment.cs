    using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class F1 : IF1
    {
        /// <summary>
        /// A csapatnak hány versenyzője van?
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <returns>A versenyzők száma</returns>
        /// <exception cref="F1Exception">A csapat nem létezik, nem lehet megállapítani, hány versenyzője van.</exception>
        public int getNumberOfRacers(string teamName)
        {
            foreach (Team team in teams)
            {
                if (team.getName() == teamName)
                {
                    return team.getNumberOfRacers();
                }
            }
            throw new F1Exception("A csapat nem létezik, nem lehet megállapítani, hány versenyzője van.");

        }
        /// <summary>
        /// Az adott csapat versenyzőinek listája
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <returns>A versenyzők listája, ha nincs csapat akkor null</returns>
        public List<Racer> getRacersFromTheTeam(string teamName)
        { 
            foreach (Team team in teams)
            {
                if (team.getName()== teamName)
                {
                    return team.getRacers();
                }
            }

            return null;
        }

        /// <summary>
        /// Adott teamhez a Racer hozzáadása
        /// Hozzáadáskor kivételt el kell kapni és loggolni kell
        /// </summary>
        /// <param name="teamName">Ebbe a csapatba kell felvenni a versenyzőt</param>
        /// <param name="newRacer">Az új versenyző</param>
        /// <exception cref="F1Exception">A versenyző evvel a névvel már létezik (loggolni is)</exception>
        /// <exception cref="F1Exception">A csapat nem létezik (loggolni is)</exception>
        public void addRacerToTeam(string teamName, Racer newRacer)
        {
            foreach (Team team in teams)
            {
                if (team.getName()==teamName)
                {
                    try
                    {
                        team.addRacer(newRacer);
                    }
                    catch (TeamException e)
                    {
                        Debug.WriteLine(e.Message);
                        throw new F1Exception(e.Message);
                    }
                }
            }
            Debug.WriteLine("A csapat nem létezik");
            throw new F1Exception("A csapat nem létezik");
        }

        /// <summary>
        /// Adott versenyző törlése a csapatban
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        /// <exception cref="F1Exception">A csapat nem létezik, nem lehet törölni a versenyzőjét</exception>
        public void deleteRacerInTeam(string teamName, string racerName, int racerAge)
        {
            foreach (Team team in teams)
            {
                if (team.getName() == teamName)
                {
                    team.deleteRacer(racerName, racerAge);
                    return;
                }
            }
            throw new F1Exception("A csapat nem létezik, nem lehet törölni a versenyzőjét");
        }

        /// <summary>
        /// Átnézi az összes csapat összes versenyzőjét és megállapítja a
        /// jelenlegi legnagyobb Racer ID-t. Eggyel nagyobbat ad vissza
        /// Ha egyáltalán nincs csapat vag egy versenyző sincs akkor egyet
        /// </summary>
        /// <returns>Az eddigi legnagyobbnál eggyel nagyobbat. Ha egyáltalán nincs csapat vag egy versenyző sincs akkor egyet</returns>
        public int getNextRacerId()
        {
            int maxId = -1;

            foreach (Team t in teams)
            {
                if (maxId < t.getMaxId())
                {
                    maxId = t.getMaxId();
                }
            }

            if (maxId > 0)
            {
                return 1;
            }
            else
            {
                return maxId + 1;
            }
        } 

        /// <summary>
        /// Az adott csapatban lévő versenyző ID-je
        /// Feladat a kivétel megírása, ha a csapat nem létezik
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>A versenyző ID-je</returns>
        public int getRacerId(string teamName, string racerName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    return t.getRacerId(racerName);
                }
            }
            return 0;
        }


        public void updateReacerInTeam(string teamName, string oldRacerName, Racer newRacer)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.updateRacer(oldRacerName, newRacer);
                    return;
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet módosítani a versenyzőjének adatait.");
        }

        /// <summary>
        /// Van-e adott versenyző
        /// </summary>
        /// <param name="racerName">A keresett versenyző neve</param>
        /// <param name="racerAge">A keresett versenyző életkora</param>
        /// <returns>true ha van és false ha nincs</returns>
        public bool existRacer(string racerName, int racerAge)
        {
            foreach (Team team in teams)
            {
                if (team.isRacerExist(racerName, racerAge))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Adott csapat adott nevű versenyzőjének megkeresése
        /// </summary>
        /// <param name="teamName">A csapat neve, amelynek tagja a versenyző</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>A versenyző</returns>
        /// <exception cref="F1Exception">Az adott nevű csapat nem létezik.</exception>
        public Racer searchRacerByName(string teamName, string racerName)
        { 
            foreach (Team team in teams)
            {
                if (team.getName()== teamName)
                {
                    return team.serchRacerByName(racerName);
                }
            }
            throw new F1Exception("Az adott nevű csapat nem létezik");
        }
    }
}
