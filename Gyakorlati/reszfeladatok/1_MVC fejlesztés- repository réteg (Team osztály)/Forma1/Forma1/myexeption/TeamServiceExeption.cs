using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.myexeption
{
    class TeamServiceExeption : Exception
    {
        public TeamServiceExeption(string message)
            : base(message)
        { }
    }
}
