using Forma1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    interface ITeamManageRacers
    {
        void add(Racer r);
        void delete(string name);
        void update(string name, Racer newRacer);
    }
}
