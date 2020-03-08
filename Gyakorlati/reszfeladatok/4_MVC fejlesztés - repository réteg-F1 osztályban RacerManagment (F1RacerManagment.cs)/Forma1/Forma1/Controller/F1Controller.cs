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
        public List<string> getTeamNameList()
        {
            return teamService.getTeamNameList();
        }

        /// <summary>
        /// Csapatnevek lekérése egy adott csapat nevének kihagyásával
        /// </summary>
        /// <param name="teamName">Ennek a csapatnak a neve nem szerepelhet a listába</param>
        /// <returns></returns>
        public List<string> getTeamNameListExclude(string teamName)
        {
            return teamService.getTeamNameListExclude(teamName);
        }

        /// <summary>
        /// Csapat hozzáadása a Forma1-hez
        /// </summary>
        /// <param name="teamName">A csapat</param>

        public void addTeamToF1(string teamName)
        {
            if (teamService.existTeamName(teamName))
                throw new ControllerException(teamName + " csapat már létezik.");
            try
            {
                NameValidator nv = new NameValidator(teamName);
                nv.validation();
            }
            catch (NameNotValidNameIsEmptyException nnve)
            {
                throw new ControllerException(teamName + " nem megfelelő csapatnév, mivel üres.");
            }
            catch (NameNotValidFirstLetterProblemException nnve)
            {
                throw new ControllerException(teamName + " nem megfelelő csapatnév, mivel az első betű nem nagybetű.");
            }

            teamService.addTeam(teamName);
        }

        /// <summary>
        /// Csapat nevének módosítása
        /// </summary>
        /// <param name="oldTeamName">A módosítandó csapat neve</param>
        /// <param name="newTeamName">A csoport új neve</param>
        public void modifyTeamName(string oldTeamName, string newTeamName)
        {
            if (teamService.existTeamName(newTeamName))
                throw new ControllerException(newTeamName + " csapat már létezik. Erre a névre nem lehet módosítani!");
            try
            {
                NameValidator nv = new NameValidator(newTeamName);
                nv.validation();
                teamService.modifyTeamName(oldTeamName, newTeamName);
            }
            catch (NameNotValidNameIsEmptyException nnve)
            {
                throw new ControllerException(newTeamName + " nem megfelelő csapatnév, mivel üres.");
            }
            catch (NameNotValidFirstLetterProblemException nnve)
            {
                throw new ControllerException(newTeamName + " nem megfelelő csapatnév, mivel az első betű nem nagybetű.");
            }
            catch (TeamServiceExeption tse)
            {
                throw new ControllerException(tse.Message);
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
        /// Forma1 összbérköltségének meghatározása
        /// </summary>
        /// <returns></returns>
        public int getF1Salary()
        {
            return teamService.getF1Salary();
        }

        /// <summary>
        /// Adott nevű csapat bérköltségének meghatározása
        /// </summary>
        /// <param name="teamName"></param>
        /// <returns></returns>
        public int computeTeamSalary(string teamName)
        {
            if (!teamService.existTeamName(teamName))
                return 0;
            else
                return teamService.getTeamSalary(teamName);
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
