using Moq;
using TopSolutions.ConsoleApp.OOP.Classes;
using TopSolutions.ConsoleApp.OOP.Interface;
using TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple.Contract;

namespace TopConsoleNunit.Test.Patterns.Factory
{
    public class CookTest
    {
        private Mock<ICook> _cookMock;
        [SetUp]
        public void Setup()
        {
            _cookMock = new Mock<ICook>();
        }

        [Test]
        public void CookFood_ShouldInvokeCookFoodMethod()
        {
            // Arrange
            _cookMock.Setup(n => n.CookFood());

            // Act
            _cookMock.Object.CookFood();

            // Assert
            _cookMock.Verify(n => n.CookFood(), Times.Once);
        }
        [Test]
        public void GetProfile_ShouldReturnProfile()
        {
            // Arrange
            _cookMock.Setup(a => a.GetProfile(It.IsAny<string>())).Returns("Profile");

            // Act
            var profile = _cookMock.Object.GetProfile("Profile");

            // Assert
            Assert.AreEqual("Profile", profile);
        }

        
    }
}
