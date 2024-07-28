using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Interface;
using TopSolutions.ConsoleApp.OOP.Classes;
using Moq;

namespace TopConsoleNunit.Test.OOP.Recipe
{

    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicRecipeTest()
        {
            var serviceMock = new Mock<IRecipe>();
            Ingredient ingredient = new Ingredient()
            {
                Name = "Clove",
                Description = "Pungent spice from Zanzibar",
                Type = IngredientType.Spice
            };
            List<Ingredient> iList = new List<Ingredient>();
            iList.Add(ingredient);
            serviceMock.Setup(n => n.GetIngredients(ingredient)).Returns(iList);

            Assert.IsTrue(serviceMock.Name.Equals("Clove"));
        }
    }
}
