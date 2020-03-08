using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forma1.myexeption;

namespace Forma1.repository
{
    partial class F1 : IF1
    {
        List<Team> teams;

        /// <summary>
        /// Forma 1 konstruktor
        /// </summary>
        public F1()
        {
            teams = new List<Team>();
        }

        /// <summary>
        /// Új csapat hozzáadása a Forma1-hez
        /// </summary>
        /// <param name="t">A csapat</param>
        public void add(Team t)
        {
            teams.Add(t);
        }

        /// <summary>
        /// Adott nevű csapat törlése
        /// Kivétel dobás ha a csapat nem létezik
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        public void delete(string teamName)
        {
            int index = 0;
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.deleteAllRacersInTeam();
                    teams.RemoveAt(index);
                    return;
                }
                index = index + 1;
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet törölni");
        }        

        /// <summary>
        /// Adott nevű csapat nevének módosítása
        /// Kivétel dobás, ha a csapat nem létezik
        /// </summary>
        /// <param name="teamName">A csapat régi neve</param>
        /// <param name="newTeamName">A csapat új neve</param>
        public void update(string teamName, string newTeamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.update(newTeamName);
                    return;
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet módosítani");
        }

        /// <summary>
        /// Adott nevű csapat bérköltsége
        /// </summary>
        /// <returns>A bérköltség</returns>
        public int getF1Salary()
        {
            int sum = 0;
            foreach (Team t in teams)
            {
                sum = sum + t.getTeamSalary();
            }
            return sum;
        }

        /// <summary>
        /// A csapatok nevének listája
        /// </summary>
        /// <returns>A csapat nevek listája</returns>
        public List<string> getTeamNameList()
        {
            List<string> tnl = new List<string>();
            foreach (Team t in teams)
                tnl.Add(t.getName());
            return tnl;
        }

        /// <summary>
        /// Van-e adott nevű csapat
        /// </summary>
        /// <param name="teamName">A keresett csapat neve</param>
        /// <returns>true ha van és false ha nincs</returns>
        public bool existTeamName(string teamName)
        {
            foreach (Team t in teams)
                if (t.getName() == teamName)
                    return true;
            return false;
        }

        /// <summary>
        /// Adott nevű csapat törlése
        /// Kivétel dobás, ha a csapat nem létezik
        /// </summary>
        /// <param name="teamNameToDelete"></param>
        public void deleteTeam(string teamNameToDelete)
        {
            int index = 0;
            foreach (Team t in teams)
            {
                if (t.getName() == teamNameToDelete)
                {
                    t.deleteAllRacersInTeam();
                    teams.RemoveAt(index);
                    return;
                }
                index += 1;
            }
            throw new F1Exception(teamNameToDelete + " nevű csapat nem létezik, nem lehet törölni.");
        }

        /// <summary>
        /// Van-e adott versenyző
        /// </summary>
        /// <param name="racerName">A keresett versenyző neve</param>
        /// <param name="racerAge">A keresett versenyző életkora</param>
        /// <returns>true ha van és false ha nincs</returns>
        public bool existRacer(string racerName, int racerAge)
        {
            foreach (Team t in teams)
            {
                if (t.isRacerExist(racerName, racerAge))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Adott csapat adott nevű versenyzőjének megkeresése
        /// Kivétel dobás, ha a versenyző nem létezik
        /// </summary>
        /// <param name="teamName">A csapat neve, amelynek tagja a versenyző</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns>A versenyző</returns>
        public Racer searchRacerByName(string teamName, string racerName)
        {
            int index = 0;
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    return t.serchRacerByName(racerName);
                }
            }
            throw new F1Exception(teamName + " nevű csapat nem létezik, nem lehet " + racerName + " nevű versenyzője.");
        }
    }
}
