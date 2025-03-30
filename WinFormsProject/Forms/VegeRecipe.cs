using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopSolutions.ConsoleApp.Patterns.Creational.Factory.FactoryDesign;

namespace WinFormsProject.Forms
{
    public partial class VegeRecipe : Form
    {
        List<string> vegeList;
        List<string> otherList;
        IVegetarianRecipe sattvicRecipe = VegetarianRecipeFactory.GetRecipe("Sattvic");
        IVegetarianRecipe veganRecipe = VegetarianRecipeFactory.GetRecipe("Vegan");
        IVegetarianRecipe jainRecipe = VegetarianRecipeFactory.GetRecipe("Jain");
        public VegeRecipe()
        {
            InitializeComponent();
            vegeList = new List<string>();
            otherList = new List<string>();

        }

        private void addVegeButton_Click(object sender, EventArgs e)
        {
            var vegetable = vegeCombo.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(vegetable))
            {
                vegeList.Add(vegetable);
                vegeListBox.Text += vegetable + " ";
            }

        }

        private void addOtherButton_Click(object sender, EventArgs e)
        {
            var other = otherCombo.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(other))
            {
                otherList.Add(other);
                otherListBox.Text += other + " ";
            }

        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            //Get strings list
            List<string> combinedIngredients = new List<string>();
            combinedIngredients.AddRange(vegeList);
            combinedIngredients.AddRange(otherList);
            //Determine type
            if (CategoryCombo.SelectedItem != null)
            {
                //determine category
                if (IsSelectionValid(CategoryCombo.SelectedItem.ToString(), combinedIngredients))
                {
                    VerdictLabel.Text = "Valid ingredients, good to go!";
                }
                else
                {
                    VerdictLabel.Text = "Invalid ingredients, please redo";
                }
            }
        }
        private bool IsSelectionValid(string type, List<string> ingredients)
        {
            bool isValid = false;
            if (type.Equals("Jain"))
            {
                isValid = jainRecipe.GetValidIngredients(ingredients);
                resultLabel.Text = jainRecipe.GetValidationResults();
            }
            if (type.Equals("Sattvic"))
            {
                isValid = sattvicRecipe.GetValidIngredients(ingredients);
                resultLabel.Text = sattvicRecipe.GetValidationResults();
            }
            if (type.Equals("Vegan"))
            {
                isValid = veganRecipe.GetValidIngredients(ingredients);
                resultLabel.Text = veganRecipe.GetValidationResults();
            }

            return isValid;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            vegeListBox.Clear();
            otherListBox.Clear();
            vegeList.Clear();
            otherList.Clear();
            vegeCombo.SelectedIndex = -1;
            otherCombo.SelectedIndex = -1;
            CategoryCombo.SelectedIndex = -1;
            resultLabel.Text = "";
        }
    }
}
