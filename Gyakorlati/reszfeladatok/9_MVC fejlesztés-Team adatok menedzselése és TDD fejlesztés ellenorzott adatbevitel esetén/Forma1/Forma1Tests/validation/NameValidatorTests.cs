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
            }
            Assert.Fail("Üres névre nem dob kivételt!");                            
        }
        [TestMethod()]
        public void validationTestNameNotBeginWithUpperCase()
        {
            try
            {
                NameValidator nv = new NameValidator("nemecsek");               
            }
            catch
            {
            }          
        }
        [TestMethod()]
        public void validationTestNameValid()
        {            
        }
    }
}