using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant;

namespace TopConsoleNunit.Test.SOLID.DIP.Basic
{
    [TestFixture]
    public class BasicTestDIP
    {
        private EmployeeDataAccessLogic _employeeDataAccessLogic;
        [SetUp]
        public void Setup()
        {
            _employeeDataAccessLogic = new EmployeeDataAccessLogic();
        }

        [Test]
        [TestCase(1, "UK", 1000, ExpectedResult = 1500)]
        [TestCase(2, "Canada", 1000, ExpectedResult = 1200)]
        [TestCase(3, "USA", 1000, ExpectedResult = 1200)]
        [TestCase(4, "UAE", 1000, ExpectedResult = 1200)]
        public double ProcessForeignPay_ShouldReturnCorrectPay(int employeeId, string country, double pay)
        {
            // Act
            var result = _employeeDataAccessLogic.ProcessForeignPay(employeeId, country, pay);

            // Assert
            return result;
        }
        [Test]
        [TestCase("UAE", ExpectedResult = true)]
        [TestCase("Australia", ExpectedResult = false)]
        [TestCase("UK", ExpectedResult = true)]
        [TestCase("NZ", ExpectedResult = false)]
        public bool ForeignValidation_CountryIsForeign(string country) 
        { 
            //act 
            var result = _employeeDataAccessLogic.IsAForeignCountry(country);
            //Assert
            return result;
        }
    }
}
