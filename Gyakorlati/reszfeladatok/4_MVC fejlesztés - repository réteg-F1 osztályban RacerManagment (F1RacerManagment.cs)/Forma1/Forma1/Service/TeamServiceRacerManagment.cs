using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forma1.repository;

namespace Forma1.service
{
    partial class TeamService
    {
        /// <summary>
        /// A következő versenyző ID-jének meghatározása a repository segítségével
        /// </summary>
        /// <returns>a következő versenyző ID-je</returns>
        public int getNextRacerId()
        {
            return f1Repository.getNextRacerId();
        }

        /// <summary>
        /// Versenyző hozzáadása adott nevű csapathoz
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="newRacer">A versenyző</param>
        public void addReacerToTeam(string teamName, Racer newRacer)
        {
            f1Repository.addRacerToTeam(teamName, newRacer);
        }

        /// <summary>
        /// Adott nevű csapatban adott nevű versenyző keresése a repository segítségével
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>A megtalált versenyző</returns>
        public Racer searchRacerByName(string teamName, string racerName)
        {
            return f1Repository.searchRacerByName(teamName, racerName);
        }

        /// <summary>
        /// Adott nevű csapatban adott nevű versenyzőnek az ID-je
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>Az ID</returns>
        public int getRacerId(string teamName, string racerName)
        {
            return f1Repository.getRacerId(teamName, racerName);
        }

        /// <summary>
        /// Adott nevű csapatban adott nevű versenyző adatainak lecserélése új adatokkalű
        /// A feladat a repository megfelelő függvénye valósítja meg
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="oldRacerName">A módosítandó versenyző neve</param>
        /// <param name="newRacer">Az új versenyző adatai</param>
        public void updateReacerInTeam(string teamName, string oldRacerName, Racer newRacer)
        {
            f1Repository.updateReacerInTeam(teamName, oldRacerName, newRacer);
        }

        /// <summary>
        /// Adott csapatban adott nevű és életkorú versenyző törlése

        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        public void deleteRacerInTeam(string teamName, string racerName, int racerAge)
        {
            f1Repository.deleteRacerInTeam(teamName, racerName, racerAge);
        }

        /// <summary>
        /// Versenyző átrakása egyik csapatból a másikba
        /// </summary>
        /// <param name="fromTeamName">Ebből a csapatből rakjuk át</param>
        /// <param name="toTeamName">Ebbe a csapatba rakjuk át</param>
        /// <param name="movedRacerName">A versenyző neve</param>
        public void moveToTeam(string fromTeamName, string toTeamName, string movedRacerName)
        {
            Racer r = searchRacerByName(fromTeamName, movedRacerName);
            f1Repository.addRacerToTeam(toTeamName, r);
            f1Repository.deleteRacerInTeam(fromTeamName , r.getName(), r.getAge());
        }

        /// <summary>
        /// Adott nevé és életkorú versenyző lézetik-e
        /// A feladat a repository megfelelő függvénye valósítja meg
        /// </summary>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        /// <returns></returns>
        public bool existRacer(string racerName, int racerAge)
        {
            if (f1Repository.existRacer(racerName, racerAge))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Adott csapatban lévő versenyzők nevei
        /// </summary>
        /// <param name="teamName"></param>
        /// <returns></returns>
        public List<string> getRacerNameFromTheTeam(string teamName)
        {
            return f1Repository.getRacerNameFromTheTeam(teamName);
        }

    }
}
