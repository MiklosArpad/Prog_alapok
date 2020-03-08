using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.MyException
{
    class RepositoryException : Exception
    {
        public RepositoryException(string message)
            : base(message)
        { }
    }
}
