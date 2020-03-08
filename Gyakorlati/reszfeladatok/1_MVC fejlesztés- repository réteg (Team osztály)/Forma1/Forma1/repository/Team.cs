using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    partial class Team : ITeam
    {
        private string name;
        List<Racer> racers;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Az új csapat neve</param>
        public Team(string name)
        {
            racers = new List<Racer>();
        }
        /// <summary>
        /// getter
        /// </summary>
        /// <returns>A csapat neve</returns>
        public string getName()
        {
            return "";
        }
        /// <summary>
        /// Csapat törlésének előkészítése
        /// A listáből minden versenyzőt törlünk
        /// </summary>
        public void deleteAllRacersInTeam()
        {
            
        }
        /// <summary>
        /// A csapat versenyzőinak összbére
        /// </summary>
        /// <returns>Csapat bérkifezése</returns>
        public int getTeamSalary()
        {
            return 0;
        }
        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Csapat új neve</param>
        public void update(string newName)
        {           
        }
        /// <summary>
        /// A csapat versenyzőinek nevének listája
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        public List<string> getRacerNames()
        {
            List<string> racerNamesList = new List<string>();
            return racerNamesList;
        }
    }
}
