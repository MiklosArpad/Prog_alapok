using Forma1.myexeption;
using Forma1.repository;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.controller
{
    partial class F1Controller
    {
        /// <summary>
        /// Versenyző hozzáadása a csapathoz
        /// Ellenörizze, hogy az argumentumbeli számadadok megfelelő formátumuak-e, ha nem dobjon kivételt
        /// NameValidator, AgeValidator és SalaryValidatorral ellenörizze az adatokat. Ha valamelyik nem jó, dobjon kivételt
        /// Alsóbb rétegek segítségével, ellenörizze, hogy az adott nevű és életkorú versenyző tagja-e a csapatnak, ha igen dobjon kivételt
        /// Alsóbb rétegek segítségével kérje, le a következő versenyző ID-jét
        /// Hozza létre az új Racert-t. Az alsóbb rétegek kivételeit kapja el, és adja tovább
        /// Adja hozzá az új versenyzőt a csapathoz. Kapja el az elsó rétegek kivételeit és adja tovább
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        /// <param name="racerSalary">A versenyző bérköltsége</param>
        public void addRacerToTeam(string teamName, string racerName, string racerAge, string racerSalary)
        {
            // GUI csak stringben tárol le adatot: ERGÓ a számokat is!
            // Controller feladata a stringben tárolt számadatokat (racerAge, racerSalary) átkonvetárlni!!!!

            // 1. lépés: Ellenörizze, hogy az argumentumbeli számadadok megfelelő formátumuak-e, ha nem dobjon kivételt

            //1. megoldás: TryParse-szal:
            //
            //int mibeMentjukElAKonvertáltErteket = Convert.ToInt32(racerAge);
            // deklarálom az integert, amibe a Convert.ToInt32() függvény a stringet belekonvertálja int-re!!
            //if (!int.TryParse(racerAge, out int integerRacegAge)) // true -> ha sikeül a racerAge (string paramétert) belekonvertálni az out-tal kifele jövő int tiususú változóba
            //{
            //    
            //    throw new ControllerException("Nem sikerült az életkort átkonvertálni!");
            //}
            //if (!int.TryParse(racerSalary, out int integerRacegSalary)) // true -> ha sikeül a racerAge (string paramétert) belekonvertálni az out-tal kifele jövő int tiususú változóba
            //{
            //    // int integerRacegSalary = Convert.ToInt32(racerSalary);
            //    throw new ControllerException("Nem sikerült a fizetzést átkonvertálni!");
            //}

            //2. megoldás Convert osztállyal:
            //

            int integerRacerAge;
            int integerRacerSalary;

            try
            {
                integerRacerAge = Convert.ToInt32(racerAge); // 3o

            }
            catch (Exception ex)
            {
                throw new ControllerException(ex.Message);
            }

            try
            {
                integerRacerSalary = Convert.ToInt32(racerSalary);
            }
            catch (Exception ex)
            {
                throw new ControllerException(ex.Message);
            }


            // ha idáig eljutunk akkor sikerült a két számadatot integerrel konvertálni!

            // 2. lépés: NameValidator, AgeValidator és SalaryValidatorral ellenörizze az adatokat. Ha valamelyik nem jó, dobjon kivételt

            try
            {
                NameValidator nv = new NameValidator(racerName);
                nv.validation();
            }
            catch (Exception e)
            {

                throw new ControllerException(e.Message);
            }

            try
            {
                AgeValidator av = new AgeValidator(integerRacerAge);
                av.validation();
            }
            catch (Exception e)
            {

                throw new ControllerException(e.Message);
            }
            try
            {
                SalaryValidator sv = new SalaryValidator(integerRacerSalary);
                sv.validation();
            }
            catch (Exception e)
            {

                throw new ControllerException(e.Message);
            }


            if (teamService.existRacer(racerName, integerRacerAge))
            {
                throw new ControllerException("Ez a versenyő mér létezik!");
            }


            int nextID = teamService.getNextRacerId();

            Racer racer;

            try
            {
                racer = new Racer(nextID, racerName, integerRacerAge, integerRacerSalary);
            }
            catch (Exception e)
            {

                throw new ControllerException(e.Message);
            }

            teamService.addReacerToTeam(teamName, racer);


        }

        /// <summary>
        /// Versenyző adatainak módosítása
        /// Kösse be a Validatorokkat a metódusba!
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="oldRacerName">A versenyző régi neve</param>
        /// <param name="racerName">A versenyző új neve</param>
        /// <param name="racerAge">A versenyző új neve</param>
        /// <param name="racerSalary">A versenyző költsége</param>
        public void updateRacerInTeam(string teamName, string oldRacerName, string racerName, string racerAge, string racerSalary)
        {
            int racerAgeNumber = 0;
            if (!int.TryParse(racerAge, out racerAgeNumber))
                throw new ControllerException("A megadott életkor nem megfelelő alakú szám!");
            int racerSalaryNumber = 0;
            if (!int.TryParse(racerSalary, out racerSalaryNumber))
                throw new ControllerException("A megadott fizetés nem megfelelő alakú szám!");


            if (teamService.existRacer(racerName, racerAgeNumber))
                throw new ControllerException("Már létezik " + racerName + " nevű versenyző, aki " + racerAge + " éves.");

            // VALIDÁCIÓ

            try
            {
                NameValidator nv = new NameValidator(racerName);
                nv.validation();
            }
            catch (Exception e)
            {

                throw new ControllerException(e.Message);
            }

            try
            {
                AgeValidator av = new AgeValidator(racerAgeNumber);
                av.validation();
            }
            catch (Exception e)
            {

                throw new ControllerException(e.Message);
            }
            try
            {
                SalaryValidator sv = new SalaryValidator(racerSalaryNumber);
                sv.validation();
            }
            catch (Exception e)
            {

                throw new ControllerException(e.Message);
            }

            try
            {
                int racerId = teamService.getRacerId(teamName, oldRacerName);
                if (racerId > 0)
                {
                    Racer newRacer = new Racer(racerId, racerName, racerAgeNumber, racerSalaryNumber);
                    teamService.updateReacerInTeam(teamName, oldRacerName, newRacer);
                }
                else
                    throw new ControllerException("A megadott versenyőjnek nem találom az azonosítáját");
            }
            catch (TeamServiceExeption tse)
            {
                throw new ControllerException(tse.Message);
            }
            catch (RacerException re)
            {
                throw new ControllerException(re.Message);
            }
        }

        /// <summary>
        /// Adott csapatban lévő versenyző törlése
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <param name="racerAge">A versenyző életkora</param>
        public void deleteRacerInTeam(string teamName, string racerName, string racerAge)
        {
            int racerAgeNumber = 0;
            if (!int.TryParse(racerAge, out racerAgeNumber))
                throw new ControllerException("A megadott életkor nem megfelelő alakú szám!");
            try
            {
                teamService.deleteRacerInTeam(teamName, racerName, racerAgeNumber);
            }
            catch (TeamServiceExeption tse)
            {
                throw new ControllerException(tse.Message);
            }
        }

        /// <summary>
        /// Ha a csapat létezik, akkor a csapar versenyzőinek listája
        /// Ha a csapat tézeik, kérje le a versenyzőit
        /// A metódus visszatérési értékének megfelelő adatstruktúrába adja vissza a versenyzők neveit
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <returns></returns>
        public List<string> getTeamRacersName(string teamName)
        {
            List<Racer> racers = teamService.getRacerFromTheTeam(teamName);

            List<string> racerNames = new List<string>();

            foreach (Racer r in racers)
            {
                racerNames.Add(r.getName());
            }

            return racerNames;
        }

        /// <summary>
        /// Ha a csapat létezik, akkor adott nevű versenyzőjének megkeresése
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <param name="racerName">A versenyző neve</param>
        /// <returns></returns>
        public Racer searchRacerByName(string teamName, string racerName)
        {
            if (teamService.existTeamName(teamName))
                return teamService.searchRacerByName(teamName, racerName);
            return null;
        }
    }
}
