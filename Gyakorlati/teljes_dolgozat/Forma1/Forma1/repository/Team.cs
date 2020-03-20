
using Forma1.myexeption;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class Team : ITeam, ITeamSalary
    {
        private string name;
        private List<Racer> racers;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Az új csapat neve</param>
        public Team(string name)
        {
            // Adattagok beállítása valamely kezdőértékre
            try
            {

                NameValidator nv = new NameValidator(name);
                nv.validation();

            }
            catch (NameNotValidNameIsEmptyException e)
            {
                Debug.WriteLine(e.Message);
                throw new TeamException(e.Message);
            }
            catch (NameNotValidFirstLetterProblemException e)
            {
                Debug.WriteLine(e.Message);
                throw new TeamException(e.Message);
            }

            this.name = name;
            racers = new List<Racer>();
        }

        /// <summary>
        /// getter
        /// </summary>
        /// <returns>A csapat neve</returns>
        public string getName()
        {
            return name;
        }
        /// <summary>
        /// Csapat törlésének előkészítése
        /// A listából minden versenyzőt törlünk
        /// </summary>
        public void deleteAllRacersInTeam()
        {
            racers.Clear();
        }        
        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Csapat új neve</param>
        public void update(string newName)
        {
            this.name = newName;
        }
        /// <summary>
        /// A csapat versenyzőinek listáját adja vissza
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        public List<Racer> getRacers()
        {
            return racers;
        }

        public int getTeamSalary()
        {
            int osszeg = 0;

            foreach(Racer racer in racers)
            {
                osszeg += racer.getSalary();
            }
            return osszeg;
        }
    }
}
