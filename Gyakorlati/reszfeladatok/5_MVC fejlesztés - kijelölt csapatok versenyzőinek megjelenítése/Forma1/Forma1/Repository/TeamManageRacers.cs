using Forma1.Model;
using Forma1.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    partial class Team : ITeamManageRacers
    {
        public void add(Racer r)
        {
            racers.Add(r);
        }

        public void delete(string name)
        {
            int index = 0;
            foreach (Racer r in racers)
            {
                if (r.getName() == name)
                {
                    racers.RemoveAt(index);
                    return;
                }
                index = index + 1;
            }
            throw new RepositoryException(name + " versenyző nincs a csapatban, ezért nem lehet törölni");
        }

        public void update(string nameToModify, Racer newRacer)
        {
            foreach(Racer r in racers)
            {
                if (r.getName()== nameToModify)
                {
                    r.update(newRacer);
                }
            }
            throw new RepositoryException(nameToModify + " versenyző nincs a csapatban, ezért nem lehet módosítani az adatait.");
        }
    }
}
