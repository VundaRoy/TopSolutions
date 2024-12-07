using TopSolutions.ConsoleApp.Patterns.Creational.Singleton.LazyLoad;

namespace TopConsoleNunit.Test.Patterns.Singleton.Lazyload
{
    [TestFixture]
    public class NationalVoterRegistryTests
    {
        [Test]
        public void Register_ShouldCallPrintVoter()
        {
            // Arrange
            var nationalVoterRegistry = new NationalVoterRegistry();
            var expectedOutput = "Voter is oldham";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                nationalVoterRegistry.Register();

                // Assert
                var result = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput, result);
            }
        }
    }
}
