using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    interface IF1Salary
    {
        /// <summary>
        /// F1 bérköltsége
        /// </summary>
        /// <returns>A bérköltség</returns>
        int getF1Salary();
        /// <summary>
        /// Team bérköltsége
        /// </summary>
        /// <returns>A bérköltség</returns>
        int getTeamSalary(string teamName);
    }
}
