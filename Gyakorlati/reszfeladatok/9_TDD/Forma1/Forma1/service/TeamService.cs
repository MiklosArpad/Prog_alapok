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
        /// Hozza létre az adott nevű csapatot.
        /// A reposiotry réteg segítségével adja hozzá az új csapatot az F1-hez
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
        /// Ellenörizze, hogy a csapatnak hány tagja van. Kérje le az adott nevű csapat versenyzőinek számát
        /// Ha a csapatnak nincs versenyzője törölje a csapatot. Ha van a csapatnak van tagja, akkor dobjon kivételt.
        /// </summary>
        /// <param name="teamNameToDelete"></param>
        public void deleteTeam(string teamNameToDelete) //"Ferrari"
        {
            int numberOfRacer = 0;
            try
            {
                numberOfRacer = f1Repository.getNumberOfRacers(teamNameToDelete); // "Ferrari"

            }
            catch (Exception)
            {

                throw;
            }
            if (numberOfRacer > 0)
                throw new TeamServiceExeption(teamNameToDelete + " csapatnak van még versenyzője, nem lehet törölni!");
            else
                try
                {
                    f1Repository.delete(teamNameToDelete);
                }
                catch (F1Exception f1e)
                {
                    throw new TeamServiceExeption(f1e.Message);
                }
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
    }
}
