using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    public class SalaryValidator
    {
        private int salary;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="salary">Tesztelendő fizetés (direkt hülyeséget írj bele tesztelésnél)</param>
        public SalaryValidator(int salary)
        {
            this.salary = salary;
        }

        public void validation()
        {
            if (isSalaryNegative()) // true esetén fut a blokkba -> akkor lesz exception
            {
                throw new SalaryIsNegativeException("A fizetés nem lehet negatív!");
            }
            if (isSalaryZero()) // true esetén fut a blokkba -> akkor lesz exception
            {
                throw new SalaryIsZeroException("A fizetés nem lehet nulla!");
            }
        }

        private bool isSalaryZero()
        {
            if (salary == 0)
            {
                return true;
            }

            return false;
        }

        private bool isSalaryNegative()
        {
            if (salary < 0)
            {
                return true;
            }

            return false;
        }
    }
}
