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
    public class AgeValidatorTests
    {
        [TestMethod()]
        public void validationTest_AgeIsNegative()
        {
            try
            {
                AgeValidator ageValidator = new AgeValidator(-18);
                ageValidator.validation();
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Nem dob kivételt negatív életkorra!");
        }

        [TestMethod()]
        public void validationTest_AgeIsZero()
        {
            try
            {
                AgeValidator ageValidator = new AgeValidator(0);
                ageValidator.validation();
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Nem dob kivételt zéró életkorra!");
        }
        [TestMethod()]
        public void validationTest_AgeIsUnderMinimum()
        {
            try
            {
                AgeValidator ageValidator = new AgeValidator(13);
                ageValidator.validation();
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Nem dob kivételt a jelentkezési minimumnál kisebb életkorra!");
        }

        [TestMethod()]
        public void validationTest_AgeIsOverMaximum()
        {
            try
            {
                AgeValidator ageValidator = new AgeValidator(41);
                ageValidator.validation();
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Nem dob kivételt a jelentkezési maximumnál nagyobb életkorra!");
        }
    }
}
