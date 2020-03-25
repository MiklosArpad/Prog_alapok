using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    public class AgeValidator
    {
        private int age;

        public AgeValidator(int age)
        {
            this.age = age;
        }
        public void validation()
        {
            if (isAgeNegative()) // true esetén fut a blokkba -> akkor lesz exception
            {
                throw new AgeIsNegativeException("Az életkor nem lehet negatív!");
            }
            if (isAgeZero()) // true esetén fut a blokkba -> akkor lesz exception
            {
                throw new AgeIsZeroException("Az életkor nem lehet nulla!");
            }
            if (isAgeUnderMinimum()) // true esetén fut a blokkba -> akkor lesz exception
            {
                throw new AgeIsUnderMinimumException("Az életkor nem lehet a jelentkezési minmumnál kevesebb!");
            }
            if (isAgeOverMaximum()) // true esetén fut a blokkba -> akkor lesz exception
            {
                throw new AgeIsOverMaximumException("Az életkor nem lehet a jelentkezési maximumnál több!");
            }
        }

        private bool isAgeOverMaximum()
        {
            if (age > 40)
            {
                return true;
            }
            return false;
            
        }

        private bool isAgeUnderMinimum()
        {
            if (age < 17)
            {
                return true;
            }
            return false;
        }

        private bool isAgeZero()
        {
            if (age == 0)
            {
                return true;
            }
            return false;
        }

        private bool isAgeNegative()
        {
            if (age < 0)
            {
                return true;
            }
            return false;
        }
    }
    
}
