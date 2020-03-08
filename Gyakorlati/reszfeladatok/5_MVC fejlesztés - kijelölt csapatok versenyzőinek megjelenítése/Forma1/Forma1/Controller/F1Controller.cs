using Forma1.Repository;
using Forma1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Controller
{
    class F1Controller
    {
        TeamService service;

        public F1Controller()
        {
            service = new TeamService();
        }

        public void provideTestData()
        {
            service.provideTestData();
        }

        public List<string> getTeamNames()
        {
            List<Team> teams = service.getTeams();
            List<string> teamNames=new List<string>();
            foreach(Team t in teams)
            {
                teamNames.Add(t.getName());
            }
            return teamNames;
            
        }


    }
}
