namespace WinFormsProject.Forms
{
    partial class VegeRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ValidateButton = new Button();
            CategoryCombo = new ComboBox();
            label1 = new Label();
            VerdictLabel = new Label();
            groupBox1 = new GroupBox();
            vegeListBox = new RichTextBox();
            vegeCombo = new ComboBox();
            addVegeButton = new Button();
            groupBox2 = new GroupBox();
            otherListBox = new RichTextBox();
            otherCombo = new ComboBox();
            addOtherButton = new Button();
            resetButton = new Button();
            resultLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ValidateButton
            // 
            ValidateButton.Location = new Point(106, 486);
            ValidateButton.Name = "ValidateButton";
            ValidateButton.Size = new Size(112, 34);
            ValidateButton.TabIndex = 0;
            ValidateButton.Text = "Validate";
            ValidateButton.UseVisualStyleBackColor = true;
            ValidateButton.Click += ValidateButton_Click;
            // 
            // CategoryCombo
            // 
            CategoryCombo.FormattingEnabled = true;
            CategoryCombo.Items.AddRange(new object[] { "Jain", "Sattvic", "Vegan" });
            CategoryCombo.Location = new Point(106, 127);
            CategoryCombo.Name = "CategoryCombo";
            CategoryCombo.Size = new Size(122, 33);
            CategoryCombo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 130);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 2;
            label1.Text = "Category";
            // 
            // VerdictLabel
            // 
            VerdictLabel.AutoSize = true;
            VerdictLabel.Location = new Point(50, 292);
            VerdictLabel.Name = "VerdictLabel";
            VerdictLabel.Size = new Size(66, 25);
            VerdictLabel.TabIndex = 3;
            VerdictLabel.Text = "Verdict";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(vegeListBox);
            groupBox1.Controls.Add(vegeCombo);
            groupBox1.Controls.Add(addVegeButton);
            groupBox1.Location = new Point(319, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 329);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vegetables";
            // 
            // vegeListBox
            // 
            vegeListBox.Location = new Point(42, 220);
            vegeListBox.Name = "vegeListBox";
            vegeListBox.Size = new Size(222, 87);
            vegeListBox.TabIndex = 2;
            vegeListBox.Text = "";
            // 
            // vegeCombo
            // 
            vegeCombo.FormattingEnabled = true;
            vegeCombo.Items.AddRange(new object[] { "Onion", "Garlic", "Potatoes", "Tomatoes", "Cabbage", "Corn", "Taro", "Tapioca", "Arvi", "Celery", "Kale", "Carrot", "Yam", "Asparagus", "Okra" });
            vegeCombo.Location = new Point(85, 74);
            vegeCombo.Name = "vegeCombo";
            vegeCombo.Size = new Size(165, 33);
            vegeCombo.TabIndex = 1;
            // 
            // addVegeButton
            // 
            addVegeButton.Location = new Point(85, 156);
            addVegeButton.Name = "addVegeButton";
            addVegeButton.Size = new Size(165, 34);
            addVegeButton.TabIndex = 0;
            addVegeButton.Text = "Add Vegetable";
            addVegeButton.UseVisualStyleBackColor = true;
            addVegeButton.Click += addVegeButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(otherListBox);
            groupBox2.Controls.Add(otherCombo);
            groupBox2.Controls.Add(addOtherButton);
            groupBox2.Location = new Point(686, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 321);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Others";
            // 
            // otherListBox
            // 
            otherListBox.Location = new Point(60, 216);
            otherListBox.Name = "otherListBox";
            otherListBox.Size = new Size(218, 84);
            otherListBox.TabIndex = 2;
            otherListBox.Text = "";
            // 
            // otherCombo
            // 
            otherCombo.AutoCompleteCustomSource.AddRange(new string[] { "Ghee", "Peanut oil", "Butter", "Jam", "Pepper", "Salt", "Sugar", "Jaggery", "Methi", "Caraway seeds" });
            otherCombo.FormattingEnabled = true;
            otherCombo.Items.AddRange(new object[] { "Rice", "Dal", "Vege Oil", "Ghee", "Butter", "Milk", "Cheese", "Honey", "Lemon", "Hing", "Cloves", "Mustard seed", "Salt", "Sugar", "Pepper" });
            otherCombo.Location = new Point(83, 75);
            otherCombo.Name = "otherCombo";
            otherCombo.Size = new Size(171, 33);
            otherCombo.TabIndex = 1;
            // 
            // addOtherButton
            // 
            addOtherButton.Location = new Point(83, 152);
            addOtherButton.Name = "addOtherButton";
            addOtherButton.Size = new Size(174, 34);
            addOtherButton.TabIndex = 0;
            addOtherButton.Text = "Add Others";
            addOtherButton.UseVisualStyleBackColor = true;
            addOtherButton.Click += addOtherButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(425, 428);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(112, 34);
            resetButton.TabIndex = 6;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            resultLabel.ForeColor = Color.Firebrick;
            resultLabel.Location = new Point(60, 404);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(74, 25);
            resultLabel.TabIndex = 7;
            resultLabel.Text = "Reason";
            // 
            // VegeRecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1202, 754);
            Controls.Add(resultLabel);
            Controls.Add(resetButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(VerdictLabel);
            Controls.Add(label1);
            Controls.Add(CategoryCombo);
            Controls.Add(ValidateButton);
            Name = "VegeRecipe";
            Text = "VegeRecipe";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ValidateButton;
        private ComboBox CategoryCombo;
        private Label label1;
        private Label VerdictLabel;
        private GroupBox groupBox1;
        private Button addVegeButton;
        private GroupBox groupBox2;
        private ComboBox vegeCombo;
        private ComboBox otherCombo;
        private Button addOtherButton;
        private RichTextBox vegeListBox;
        private RichTextBox otherListBox;
        private Button resetButton;
        private Label resultLabel;
    }
}