using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.repository
{
    interface ITeamSalary
    {
        /// <summary>
        /// A csapat versenyzőinak összbére
        /// </summary>
        /// <returns>Csapat bérkifezése</returns>
        int getTeamSalary();

    }
}
