using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using TopSolutions.ConsoleApp.SOLID.DIP.DatabaseSample;

namespace TopConsoleNunit.Test.SOLID.DIP.Database
{
    [TestFixture]
    public class DatabaseTest
    {
        private DatabaseService _databaseService;
        private StringWriter _stringWriter;

        [SetUp]
        public void SetUp()
        {
            _databaseService = new DatabaseService();
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            _stringWriter.Dispose();
        }

        [Test]
        public void Save_ShouldOutputCorrectMessage()
        {
            // Arrange
            var message = "Test message";

            // Act
            _databaseService.Save(message);

            // Assert
            var output = _stringWriter.ToString().Trim();
            Assert.AreEqual($"Save the message into the database. {message}", output);
        }

        [Test]
        public void RollBack_ShouldOutputCorrectMessage()
        {
            // Arrange
            var message = "Test message";

            // Act
            _databaseService.RollBack(message);

            // Assert
            var output = _stringWriter.ToString().Trim();
            Assert.AreEqual($"Rolling back transaction {message}", output);
        }

    }
}
