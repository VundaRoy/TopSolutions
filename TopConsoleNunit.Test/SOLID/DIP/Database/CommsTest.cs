using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample;

namespace TopConsoleNunit.Test.SOLID.DIP.Database
{
    [TestFixture]
    public class CommsTest
    {
        private Mock<IDataService> _mockDataService;
        private Comms _comms;

        [SetUp]
        public void SetUp()
        {
            _mockDataService = new Mock<IDataService>();
            _comms = new Comms(_mockDataService.Object);
        }

        [Test]
        public void SendComms_ShouldCallSaveMethod()
        {
            // Arrange
            var message = "Test message";

            // Act
            _comms.SendComms(message);

            // Assert
            _mockDataService.Verify(ds => ds.Save(message), Times.Once);
        }

        [Test]
        public void UnSendMessage_ShouldCallRollBackMethod()
        {
            // Arrange
            var message = "Test message";

            // Act
            _comms.UnSendMessage(message);

            // Assert
            _mockDataService.Verify(ds => ds.RollBack(message), Times.Once);
        }
    }
}
