using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forma1.myexeption;
using Forma1.repository;
using Forma1.service;
using Forma1.validation;

namespace Forma1.controller
{
    partial class F1Controller
    {
        TeamService teamService;

        public F1Controller()
        {
            teamService = new TeamService();
        }

        /// <summary>
        /// Test adatok inicializálása
        /// </summary>
        public void initializeTestData()
        {
            teamService.provideTestData();
        }

        /// <summary>
        /// Csapatnevek lekérése
        /// </summary>
        /// <returns>Csapatnevek listája</returns>
        public List<string> getTeamNames()
        {
            List<string> teamNames = new List<string>();
            List<Team> teams = teamService.getTeams();
            foreach(Team t in teams)
            {
                teamNames.Add(t.getName());
            }
            return teamNames;
        }

        /// <summary>
        /// Csapat hozzáadása a Forma1-hez
        ///  - ellenőrizze, a service réteg segítségével, hogy a csapat neve létezik-e, ha igen dobjon kivételt
        ///  - tesztelje, a NameValidator osztállyal, hogy a csapat neve helyesen van-e megadva
        ///  - kapja el a NameNotValidNameIsEmptyException és NameNotValidFirstLetterProblemException kivételeket, és ezekre dobjon megfelelő szövetű kivételt
        ///  - ha a név helyes, hívja meg a teamService megfelelő függvényét
        /// </summary>
        /// <param name="teamName">A csapat</param>
        /// <exeption>ControllerException</exeption>

        public void addTeamToF1(string teamName) // textBoxTeamName.Text; -> ferraro
        {
            if (teamService.existTeamName(teamName))
            {
                throw new ControllerException("Ilyen csapat már van ilyen névvel, nem lehet az F1-hez hozzá adni ");
            }

            try
            {
                NameValidator nv = new NameValidator(teamName);
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException ex)
            {
                throw new ControllerException(ex.Message);
            }
            catch (NameNotValidFirstLetterProblemException ex)
            {
                throw new ControllerException(ex.Message);
            }

            teamService.addTeam(teamName);
        }

        /// <summary>
        /// Csapat nevének módosítása a Formai-ben
        ///  - ellenőrizze, a service réteg segítségével, hogy a csapat neve létezik-e, ha igen dobjon kivételt
        ///  - tesztelje, a NameValidator osztállyal, hogy a csapat neve helyesen van-e megadva
        ///  - kapja el a NameNotValidNameIsEmptyException,NameNotValidFirstLetterProblemException,TeamServiceExeption kivételeket, és ezekre dobjon megfelelő szövetű kivételt
        ///  - ha a név helyes, hívja meg a teamService megfelelő függvényét
        /// </summary>
        /// <param name="oldTeamName">A módosítandó csapat neve</param>
        /// <param name="newTeamName">A csoport új neve</param>
        /// <exeption>ControllerException</exeption>
        public void modifyTeamName(string oldTeamName, string newTeamName)
        {
            if (teamService.existTeamName(newTeamName))
            {
                throw new ControllerException("Olyan névre akarod átnevezni, amilyen nevű csapat már van!");
            }

            try
            {
                NameValidator nv = new NameValidator(newTeamName);
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException e)
            {
                throw new ControllerException(e.Message);
            }
            catch(NameNotValidFirstLetterProblemException e)
            {
                throw new ControllerException(e.Message);
            }
            catch(TeamServiceExeption e)
            {
                throw new ControllerException(e.Message);
            }

            teamService.modifyTeamName(oldTeamName, newTeamName);

        }

        /// <summary>
        /// Adott nevű csapat törlése
        ///  - ellenőrizze, a service réteg segítségével, hogy a csapat név létezik-e. Ha nem dobjon kivételt!
        ///  - ha a csapat neve létezik, akkor hívja meg a teamServis megfelelő függvényét amely dobhat TeamServiceExeption kivételt
        /// </summary>
        /// <param name="teamNameToDelete">A törlendő csapat neve</param>
        public void deleteTeam(string teamNameToDelete)
        {
            if (!teamService.existTeamName(teamNameToDelete))
            {
                throw new ControllerException("Nem létezik a csapat");
            }

            teamService.deleteTeam(teamNameToDelete);

            //if (teamService.existTeamName(teamNameToDelete))
            //{
            //    teamService.deleteTeam(teamNameToDelete);
            //    return;
            //}
            //throw new ControllerException("Nem létezik a csapat");


            //if (teamService.existTeamName(teamNameToDelete))
            //{
            //    teamService.deleteTeam(teamNameToDelete);
            //}
            //else
            //{
            //    throw new ControllerException("Nem létezik a csapat");
            //}
        }

        /// <summary>
        /// Forma1 összbérköltségének meghatározása
        /// </summary>
        /// <returns>A bérköltség szöveges formátumban</returns>
        public string getF1Salary()
        {
            int f1Salary= teamService.getF1Salary();
            string f1SalaryToView = f1Salary.ToString();
            return f1SalaryToView;
        }

        /// <summary>
        /// Adott nevű csapat bérköltségének meghatározása
        /// </summary>
        /// <param name="teamName"></param>
        /// <returns></returns>
        public string computeTeamSalary(string teamName)
        {
            if (!teamService.existTeamName(teamName))
                return string.Empty;
            else
            {
                int f1TeamSalary=teamService.getTeamSalary(teamName);
                string f1TeamSalaryToView = f1TeamSalary.ToString();
                return f1TeamSalaryToView;
            }
        }

        /// <summary>
        /// Versenyző áthelyezése egyik csapatból a másikba
        /// </summary>
        /// <param name="fromTeamName">Ebből a csapatból</param>
        /// <param name="toTeamName">Ebbe a csapatba</param>
        /// <param name="movedRacerName">Az áthelyezendő versenyző neve</param>
        public void moveToTeam(string fromTeamName, string toTeamName, string movedRacerName)
        {
            if (!teamService.existTeamName(fromTeamName))
                throw new ControllerException(fromTeamName + " csapat nem létezik, nem lehet áthelyezni.");
            if (!teamService.existTeamName(toTeamName))
                throw new ControllerException(toTeamName + " csapat nem létezik, nem lehet áthelyezni.");
            teamService.moveToTeam(fromTeamName, toTeamName, movedRacerName);
        }

        /// <summary>
        /// Csapatnevek lekérése egy adott csapat nevének kihagyásával
        /// </summary>
        /// <param name="teamName">Ennek a csapatnak a neve nem szerepelhet a listába</param>
        /// <returns></returns>
        public List<string> getTeamNameListExclude(string teamName)
        {
            List<string> teamNames = new List<string>();
            List<Team> teams = teamService.getTeams();
            foreach (Team t in teams)
            {
                if (t.getName() != teamName)
                    teamNames.Add(t.getName());
            }
            return teamNames;
        }
    }
}
