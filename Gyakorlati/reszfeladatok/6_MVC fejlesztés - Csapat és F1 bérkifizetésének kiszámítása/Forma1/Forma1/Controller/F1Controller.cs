using Forma1.Model;
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

        public List<string> getRacerNames(string teamName)
        {
            List<Racer> racers = service.getRacers(teamName);
            List<string> racerNames = new List<string>();
            foreach (Racer r in racers)
            {
                racerNames.Add(r.getName());
            }
            return racerNames;

        }

        public int F1OsszesBer()
        {
            return service.F1OsszesBer();
            
        }

        public int CsapatOsszesBer(string teamName)
        {
            return service.CsapatOsszesBer(teamName);
        }
    }
}
