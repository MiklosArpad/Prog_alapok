using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            foreach (Team t in teams)
            {
                teamNames.Add(t.getName());
            }
            return teamNames;
        }

        public string getF1Salary()
        {
            return teamService.getF1Salary().ToString();
        }

        public string getTeamSalary(string teamName)
        {
            return teamService.getTeamSalary(teamName).ToString();
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

        /// <summary>
        /// Csapat hozzáadása a Forma1-hez
        /// NameValidator segítségével a név ellenörzése
        /// Csak akkor adja hozzá az alsó rétegek segítségével, ha a csapat neve helyes
        /// </summary>
        /// <param name="teamName">A csapat</param>
        public void addTeamToF1(string teamName)
        {
            try
            {
                NameValidator nameValidator = new NameValidator(teamName);
                nameValidator.validation();
            }
            catch (Exception e)
            {
                throw new ControllerException(e.Message);
            }

            teamService.addTeam(teamName);
        }

        /// <summary>
        /// Csapat nevének módosítása
        /// Ellenörzizze, hogy a csapat létezik-e. Ha létezik, dobjon kivételt, és azt loggolja
        /// Ellenörizze az új nevet a NameValidatorral
        /// Módosítsa a nevet, ha a név rendben van
        /// Az alsó rétegek kivételeit is kapja el, és adja tovább
        /// </summary>
        /// <param name="oldTeamName">A módosítandó csapat neve</param>
        /// <param name="newTeamName">A csoport új neve</param>
        public void modifyTeamName(string oldTeamName, string newTeamName)
        {
            // 1. lépés: Ellenörzizze, hogy a csapat létezik-e. Ha létezik, dobjon kivételt, és azt loggolja
            if (teamService.existTeamName(newTeamName))
            {
                Debug.WriteLine("Létező csaptnév!");
                throw new ControllerException("Létező csaptnév!");
            }

            // 2. lépés: Ellenörizze az új nevet a NameValidatorral
            try
            {
                NameValidator nv = new NameValidator(newTeamName);
                nv.validation();
            }
            catch (Exception ex)
            {
                throw new ControllerException(ex.Message);
            }

            // 3. lépés: Módosítsa a nevet, ha a név rendben van
            try
            {
                teamService.modifyTeamName(oldTeamName, newTeamName);
            }
            catch (Exception ex)
            {
                throw new ControllerException(ex.Message);
            }
        }

        /// <summary>
        /// Adott nevű csapat törlése
        /// </summary>
        /// <param name="teamNameToDelete">A törlendő csapat neve</param>
        public void deleteTeam(string teamNameToDelete)
        {
            if (!teamService.existTeamName(teamNameToDelete))
                throw new ControllerException(teamNameToDelete + " csapat nem létezik. Nem lehet törölni!");
            try
            {
                teamService.deleteTeam(teamNameToDelete);
            }
            catch (TeamServiceExeption tse)
            {
                throw new ControllerException(tse.Message);
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
    }
}
