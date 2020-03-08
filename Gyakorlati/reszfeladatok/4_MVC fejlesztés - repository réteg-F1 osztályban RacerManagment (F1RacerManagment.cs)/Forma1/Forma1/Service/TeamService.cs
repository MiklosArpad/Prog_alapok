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
        /// </summary>
        /// <param name="teamNameToDelete"></param>
        public void deleteTeam(string teamNameToDelete)
        {
            int numberOfRacer = f1Repository.getNumberOfRacers(teamNameToDelete);
            if (numberOfRacer > 0)
                throw new TeamServiceExeption(teamNameToDelete + " csapatnak van még versenyzője, nem lehet törölni!");
            else
                try
                {
                    f1Repository.deleteTeam(teamNameToDelete);
                }
                catch (F1Exception f1e)
                {
                    throw new TeamServiceExeption(f1e.Message);
                }
        }

        /// <summary>
        /// Csapat nevek lekérése
        /// </summary>
        /// <returns></returns>
        public List<string> getTeamNameList()
        {
            return f1Repository.getTeamNameList();
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
        
        /// <summary>
        /// Repository segítségével a Forma1 összköltségvetésének meghatározása
        /// </summary>
        /// <returns>F1 összköltségvetése</returns>
        public int getF1Salary()
        {
            return f1Repository.getF1Salary();
        }

        public  int getTeamSalary(string teamName)
        {
            return f1Repository.getTeamSalary(teamName);
        }

        /// <summary>
        /// Csapatok nevei kivéve a megadott nevű csapat
        /// Az összes csapat nevének lekérése és ezek közül az adott nevű kihagyása
        /// </summary>
        /// <param name="teamName">A megadott csapatnév</param>
        /// <returns></returns>
        public List<string> getTeamNameListExclude(string teamName)
        {
            List<string> teams = f1Repository.getTeamNameList();
            if (teams.Count > 0)
            {
                teams.Remove(teamName);
                return teams;
            }
            else
                return null;
        }


    }
}
