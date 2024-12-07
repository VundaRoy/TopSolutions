using TopSolutions.ConsoleApp.Patterns.Creational.Singleton.LazyLoad;

namespace TopConsoleNunit.Test.Patterns.Singleton.Lazyload
{
    [TestFixture]
    public class RegisterVoterTests
    {
        [Test]
        public void PrintVoter_ShouldPrintCorrectVoterName()
        {
            // Arrange
            var registerVoter = RegisterVoter.Instance;
            var voterName = "oldham";
            var expectedOutput = $"Voter is {voterName}";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                registerVoter.PrintVoter(voterName);

                // Assert
                var result = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput, result);
            }
        }
    }
}
