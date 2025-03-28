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
            label2 = new Label();
            groupBox1 = new GroupBox();
            vegeListBox = new RichTextBox();
            vegeCombo = new ComboBox();
            addVegeButton = new Button();
            groupBox2 = new GroupBox();
            otherListBox = new RichTextBox();
            otherCombo = new ComboBox();
            addOtherButton = new Button();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 292);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "Verdict";
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
            vegeCombo.Items.AddRange(new object[] { "Onion", "Garlic", "Potatoes", "Tomatoes", "Cabbage", "Corn", "Taro", "Tapioca", "Arvi", "Celery", "Kale", "Carrot" });
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
            // VegeRecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1202, 754);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
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
        private Label label2;
        private GroupBox groupBox1;
        private Button addVegeButton;
        private GroupBox groupBox2;
        private ComboBox vegeCombo;
        private ComboBox otherCombo;
        private Button addOtherButton;
        private RichTextBox vegeListBox;
        private RichTextBox otherListBox;
    }
}