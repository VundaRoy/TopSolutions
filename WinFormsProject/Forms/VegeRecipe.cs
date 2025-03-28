using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProject.Forms
{
    public partial class VegeRecipe : Form
    {
        List<string> vegeList;
        List<string> otherList;
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
                vegeList.Add(vegetable);

        }

        private void addOtherButton_Click(object sender, EventArgs e)
        {
            var other = otherCombo.SelectedItem.ToString();
            if(!string.IsNullOrEmpty(other))
                otherList.Add(other);

        }
    }
}
