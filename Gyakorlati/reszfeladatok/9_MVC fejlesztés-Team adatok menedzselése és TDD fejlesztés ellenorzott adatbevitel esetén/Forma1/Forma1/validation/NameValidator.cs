using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    public class NameValidator
    {
        private string name;
        public NameValidator(string name)
        {
            this.name = name;
        }
        public void validation()
        {
            if (isEmtyName())
                throw new NameNotValidNameIsEmptyException("A név nem lehet üres!");
            if (isFistLetterNotUppercase())
                throw new NameNotValidFirstLetterProblemException("A név nagy kezdőbetűvel kell kezdőjön!");
        }

        private bool isFistLetterNotUppercase()
        {
            return false;
        }

        private bool isEmtyName()
        {
            return false;
        }
    }
}
