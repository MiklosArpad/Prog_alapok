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
    public class NameValidatorTests
    {
        [TestMethod()]
        public void validationTestNameEmty()
        {
            try
            {
                NameValidator nv = new NameValidator("");
                nv.validation();
            }
            catch
            {
                return;
            }
            Assert.Fail("Üres névre nem dob kivételt!");
        }
        [TestMethod()]
        public void validationTestNameNotBeginWithUpperCase()
        {
            try
            {
                NameValidator nv = new NameValidator("nemecsek");
                nv.validation();
            }
            catch
            {
                return;
            }
            Assert.Fail("Nem dobja a kivételt, arra, hogy kicsi a kezdőbetű");
        }
        [TestMethod()]
        public void validationTestNameValid()
        {
            try
            {
                NameValidator nv = new NameValidator("Árpád");
                nv.validation();
            }
            catch (Exception)
            {
                return;
            }

        }


        [TestMethod()]
        public void validationTestNameIsNull()
        {
            try
            {
                NameValidator nv = new NameValidator(null);
                nv.validation();
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail("Null stringre nem dob kivételt");
        }
    }
}
