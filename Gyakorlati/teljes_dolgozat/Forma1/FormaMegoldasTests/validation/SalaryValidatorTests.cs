using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation.Tests
{
    [TestClass()]
    public class SalaryValidatorTests
    {
        [TestMethod()]
        public void testCase_SalaryIsNegativeTest()
        {
            try
            {
                SalaryValidator sv = new SalaryValidator(-10);
                sv.validation();
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Nem dobja a kivételt negatív fizetésre!");
        }

        [TestMethod()]
        public void testCase_SalaryIsZeroTest()
        {
            try
            {
                SalaryValidator sv = new SalaryValidator(0);
                sv.validation();
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Nem dobja a kivételt nulla fizetésre!");
        }
    }
}
