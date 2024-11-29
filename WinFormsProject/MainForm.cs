using WinFormsProject.Forms;

namespace WinFormsProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label2.Text = "write something";
            }
            else
            {
                label2.Text = "You typed " + textBox1.Text;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Critical"))
            {
                panel1.BackColor = Color.Red;
            }
            else
            if (comboBox1.Text.Equals("Serious"))

            {
                panel1.BackColor = Color.Pink;
            }
            if (radioButton1.Checked)
            {
                panel1.BackColor = Color.Blue;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatternsTest pt = new PatternsTest();
            pt.Show();
        }

        private void horizonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.BackColor = Color.Firebrick;
        }

        private void containerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.BackColor = Color.Gainsboro;
        }
    }
}
