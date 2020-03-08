using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    interface ITeam
    {
        void update(string newName);
        void delete();

        int getTeamSalary();
    }
}
