using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    interface ITeam
    {
        string getName();
        void update(string newName);
        void deleteAllRacersInTeam();
        int getTeamSalary();
        List<string> getRacerNames();

    }
}
