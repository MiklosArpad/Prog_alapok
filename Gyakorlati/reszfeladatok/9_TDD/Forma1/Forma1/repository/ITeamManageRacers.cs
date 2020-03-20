using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    interface ITeamManageRacers
    {
        void addRacer(Racer r);
        void deleteRacer(string name,int age);
        void updateRacer(string name, Racer newRacer);

        int getNumberOfRacers();
        Racer serchRacerByName(string racerName);
        bool isRacerExist(string racerName, int racerAge);
        int getRacerId(string racerName);
    }
}
