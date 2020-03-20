using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forma1.Model;
using Forma1.Repository;

namespace Forma1.Service
{
    class TeamService
    {
        F1 forma1Repository;

        public TeamService()
        {
            forma1Repository = new F1();
        }
        public void provideTestData()
        {
            TestData td = new TestData();
            forma1Repository = td.getTestData();
        }
        public List<Team> getTeams()
        {
            return forma1Repository.getTeam();
        }

        public List<Racer> getRacers(string teamName)
        {
            return forma1Repository.getRacers(teamName);
        }

        internal Racer searchRacerByName(string teamName, string racerName)
        {
            return forma1Repository.searchRacerByName(teamName, racerName);
        }

        internal void HozzaadCsapat(string teamName)
        {
            if (forma1Repository.LetezoCsapatE(teamName)) // ha a függvény true-t ad vissza, akkor fut az if-be
            {
                throw new Exception("Csapat már létezik!");
            }

            Team team = new Team(teamName);
            forma1Repository.add(team);
        }

        internal void ModositCsapat(string oldTeamName, string newTeamName)
        {
            if (forma1Repository.LetezoCsapatE(newTeamName)) // ha a függvény true-t ad vissza, akkor fut az if-be
            {
                throw new Exception("Csapat már létezik!");
            }

            forma1Repository.update(oldTeamName, newTeamName);
        }

        internal void TorolCsapat(string teamName)
        {
            if (forma1Repository.VanEBenneVersenyzo(teamName))
            {
                throw new Exception("Van benne versenyző, nem törölhető a csapat!");
            }

            forma1Repository.delete(teamName);
        }
    }
}
