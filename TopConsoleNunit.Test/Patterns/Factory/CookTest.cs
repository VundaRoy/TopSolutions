using Moq;
using TopSolutions.ConsoleApp.OOP.Classes;
using TopSolutions.ConsoleApp.OOP.Interface;
using TopSolutions.ConsoleApp.Patterns.Factory.Simple.Contract;

namespace TopConsoleNunit.Test.Patterns.Factory
{
    public class CookTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AsianCookTest()
        {
            var serviceMock = new Mock<ICook>();
            
            
            serviceMock.Setup(n => n.CookFood());

            Assert.IsFalse(serviceMock.Name.Equals(null));
        }
    }
}
