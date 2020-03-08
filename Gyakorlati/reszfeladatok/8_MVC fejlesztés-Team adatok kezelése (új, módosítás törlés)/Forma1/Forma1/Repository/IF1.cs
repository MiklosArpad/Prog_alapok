using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    interface IF1
    {
        void add(Team t);
        void update(string teamName, string newTeamName);
        void delete(string teamName);

        int getF1Salary();
    }
}
