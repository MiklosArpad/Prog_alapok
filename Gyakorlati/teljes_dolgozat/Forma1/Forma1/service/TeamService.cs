using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forma1.myexeption;
using Forma1.repository;

namespace Forma1.service
{
    partial class TeamService
    {
        TestData testData;
        F1 f1Repository;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public TeamService()
        {
            testData = new TestData();
            f1Repository = new F1();
        }

        /// <summary>
        /// Tesztadatok lekérése
        /// </summary>
        public void provideTestData()
        {
            f1Repository = testData.getTestData();
        }

        /// <summary>
        /// Adott nevű csapat létrehozása és hozzáadása a repository-hoz
        /// </summary>
        /// <param name="teamName">A létrehozandó csapat neve</param>
        public void addTeam(string teamName)
        {
            Team t = new Team(teamName);
            f1Repository.add(t);
        }
        
        /// <summary>
        /// Adott nevű csapat átnevezése új csapat névre
        /// Repository segítségével a csapat régi nevének lecserélése az új névre
        /// </summary>
        /// <param name="oldTeamName"></param>
        /// <param name="newTeamName"></param>
        public void modifyTeamName(string oldTeamName, string newTeamName)
        {
            try
            {
                f1Repository.update(oldTeamName, newTeamName);
            }
            catch (F1Exception  f1e)
            {
                throw new TeamServiceExeption(f1e.Message);
            }
        }

        /// <summary>
        /// Ha a csapatnak nincs tagja akkor annak törlése
        /// Ellenörizze, hogy a csapatnak nincs-e tagja.
        /// Ha nincs törölje a csapatot. Ha van a csapatnak tagja, akkor dobjon kivételt.
        /// Ha repository réteg metódus hív, és az dob kivételt, akkor azt kapja el!
        /// </summary>
        /// <param name="teamNameToDelete"></param>
        public void deleteTeam(string teamNameToDelete)
        {
        }

        /// <summary>
        /// Csapat adatainak lekérése
        /// </summary>
        /// <returns></returns>
        public List<Team> getTeams()
        {
            return f1Repository.getTeams();
        }

        /// <summary>
        /// Adott nevű csapat létezik-e
        /// </summary>
        /// <param name="teamName">A keresett csapat neve</param>
        /// <returns>true ha igen, és false ha nem</returns>
        public bool existTeamName(string teamName)
        {
            if (f1Repository.existTeamName(teamName))
                return true;
            else
                return false;
        }       
     }
}
