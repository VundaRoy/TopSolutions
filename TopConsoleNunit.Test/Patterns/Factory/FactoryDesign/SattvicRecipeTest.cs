using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryDesign;

namespace TopConsoleNunit.Test.Patterns.Factory.FactoryDesign
{
    [TestFixture]
    public class SattvicRecipeTest
    {
        private SattvicRecipe _sattvicRecipe;
        private StringWriter _stringWriter;

        [SetUp]
        public void SetUp()
        {
            _sattvicRecipe = new SattvicRecipe();
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            _stringWriter.Dispose();
        }

        [Test]
        public void GetValidIngredients_ShouldReturnFalse_WhenContainsOnionOrGarlic()
        {
            // Arrange
            var ingredients = new List<string> { "tomato", "onion", "carrot" };

            // Act
            var result = _sattvicRecipe.GetValidIngredients(ingredients);

            // Assert
            var output = _stringWriter.ToString();
            Assert.IsFalse(result);
            StringAssert.Contains("Not sattvic compliant. Ingredient contains onion", output);
        }

        [Test]
        public void GetValidIngredients_ShouldReturnTrue_WhenNoOnionOrGarlic()
        {
            // Arrange
            var ingredients = new List<string> { "tomato", "carrot", "spinach" };

            // Act
            var result = _sattvicRecipe.GetValidIngredients(ingredients);

            // Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GetValidIngredients_ShouldReturnTrue_WhenNull()
        {
            // Arrange
            var ingredients = new List<string> { null, null, null };

            // Act
            var result = _sattvicRecipe.GetValidIngredients(ingredients);

            // Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GetValidIngredients_ShouldReturnTrue_WhenEmpty()
        {
            // Arrange
            var ingredients = new List<string> { };

            // Act
            var result = _sattvicRecipe.GetValidIngredients(ingredients);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void PrepareIngredients_ShouldOutputCorrectMessage()
        {
            // Act
            _sattvicRecipe.PrepareIngredients();

            // Assert
            var output = _stringWriter.ToString().Trim();
            Assert.AreEqual("Making sattvic your goal", output);
        }
    }
}
