namespace WinFormsProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            offsetToolStripMenuItem = new ToolStripMenuItem();
            onsetToolStripMenuItem = new ToolStripMenuItem();
            containerToolStripMenuItem = new ToolStripMenuItem();
            horizonToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(231, 242);
            Button1.Name = "Button1";
            Button1.Size = new Size(112, 34);
            Button1.TabIndex = 0;
            Button1.Text = "Submit";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 78);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 169);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 3;
            label2.Text = "Waiting for input";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(889, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(54, 29);
            toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(158, 34);
            openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(158, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { offsetToolStripMenuItem, onsetToolStripMenuItem, containerToolStripMenuItem, horizonToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // offsetToolStripMenuItem
            // 
            offsetToolStripMenuItem.Name = "offsetToolStripMenuItem";
            offsetToolStripMenuItem.Size = new Size(270, 34);
            offsetToolStripMenuItem.Text = "Offset";
            // 
            // onsetToolStripMenuItem
            // 
            onsetToolStripMenuItem.Name = "onsetToolStripMenuItem";
            onsetToolStripMenuItem.Size = new Size(270, 34);
            onsetToolStripMenuItem.Text = "Onset";
            // 
            // containerToolStripMenuItem
            // 
            containerToolStripMenuItem.Name = "containerToolStripMenuItem";
            containerToolStripMenuItem.Size = new Size(270, 34);
            containerToolStripMenuItem.Text = "Container";
            containerToolStripMenuItem.Click += containerToolStripMenuItem_Click;
            // 
            // horizonToolStripMenuItem
            // 
            horizonToolStripMenuItem.Name = "horizonToolStripMenuItem";
            horizonToolStripMenuItem.Size = new Size(270, 34);
            horizonToolStripMenuItem.Text = "Horizon";
            horizonToolStripMenuItem.Click += horizonToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(473, 169);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(473, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 328);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 210);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 4;
            label3.Text = "Enter Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Critical", "Mild", "Serious" });
            comboBox1.Location = new Point(129, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(114, 257);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Alert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LemonChiffon;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(53, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Internals";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(31, 96);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(136, 29);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "International";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(29, 64);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 29);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "National";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(29, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Required";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(93, 388);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(177, 47);
            button3.TabIndex = 7;
            button3.Text = "Call Patterns";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(889, 582);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Button1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form Entry Specimen";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ColorDialog colorDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem offsetToolStripMenuItem;
        private ToolStripMenuItem onsetToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label3;
        private CheckBox checkBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button3;
        private ToolStripMenuItem containerToolStripMenuItem;
        private ToolStripMenuItem horizonToolStripMenuItem;
    }
}
