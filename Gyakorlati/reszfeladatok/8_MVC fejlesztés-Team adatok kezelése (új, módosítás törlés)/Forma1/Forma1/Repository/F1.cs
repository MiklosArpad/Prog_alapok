using Forma1.Model;
using Forma1.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    class F1 : IF1
    {
        List<Team> teams;

        public F1()
        {
            teams = new List<Team>();
        }

        public List<Team> getTeam()
        {
            return teams;
        }



        public void add(Team t)
        {
            teams.Add(t);
        }

        public bool VanEBenneVersenyzo(string teamName)
        {
            foreach (Team t in teams)
            {
                if (t.getRacers().Count != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void delete(string teamName)
        {
            int index = 0;
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.delete(); //törli a team versenyzőket
                    teams.RemoveAt(index);
                    return;
                }
                index = index + 1;
            }
            throw new RepositoryException(teamName+" csapat nem létezik, nem lehet törölni");

        }

        public bool LetezoCsapatE(string teamName)
        {
            foreach(Team t in teams)
            {
                if (t.getName()== teamName)
                {
                    return true;
                }
            }

            return false;
        }

        public Racer searchRacerByName(string teamName, string racerName)
        {            
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    return t.serchRacerByName(racerName);
                }
            }
            throw new RepositoryException(teamName + " nevű csapat nem létezik, nem lehet " + racerName + " nevű versenyzője.");
        }

        public List<Racer> getRacers(string teamName)
        {
            foreach(Team t in teams)
            {
                if (t.getName()==teamName)
                    return t.getRacers();
            }
            return null;
        }

        public int getF1Salary()
        {
            int f1Salary = 0;
            foreach(Team t in teams)
            {
                f1Salary = f1Salary + t.getTeamSalary();
            }
            return f1Salary;
        }

        public void update(string teamName, string newTeamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.update(newTeamName);
                }
            }
        }
    }
}
