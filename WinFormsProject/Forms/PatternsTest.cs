using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple.FactoryClass;

namespace WinFormsProject.Forms
{
    public partial class PatternsTest : Form
    {
        public PatternsTest()
        {
            InitializeComponent();
        }

        private void FactoryButton_Click(object sender, EventArgs e)
        {
            var cook = CookFactory.GetCookType("Asian");
            if (cook != null)
            { 
                //if(cook.Equals("Asian"))
                    FactoryButton.BackColor = Color.Red;
            }
            label1.Text = cook.GetProfile("");
        }
    }
}
