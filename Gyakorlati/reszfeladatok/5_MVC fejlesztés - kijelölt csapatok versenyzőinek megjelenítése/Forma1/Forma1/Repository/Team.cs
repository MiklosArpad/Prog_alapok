using Forma1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    partial class Team : ITeam 
    {
        private string name;
        private List<Racer> racers;

        public Team(string name)
        {
            this.name = name;
            racers = new List<Racer>();
        }

        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Csapat törlésének előkészítése
        /// A listáből minden versenyzőt törlünk
        /// </summary>
        public void delete()
        {
            racers.Clear();
        }

        /// <summary>
        /// A csapat versenyzőinak összbére
        /// </summary>
        /// <returns>Csapat bérkifezése</returns>
        public int getTeamSalary()
        {
            int salary = 0;
            foreach (Racer r in racers)
            {
                salary += r.getSalary();
            }
            return salary;
        }

        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Csapat új neve</param>
        public void update(string newName)
        {
            this.name = newName;
        }        
    }
}
