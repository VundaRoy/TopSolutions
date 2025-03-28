namespace WinFormsProject.Forms
{
    partial class PatternsTest
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
            FactoryButton = new Button();
            label1 = new Label();
            VegeRecipeButton = new Button();
            SuspendLayout();
            // 
            // FactoryButton
            // 
            FactoryButton.Location = new Point(86, 109);
            FactoryButton.Name = "FactoryButton";
            FactoryButton.Size = new Size(126, 34);
            FactoryButton.TabIndex = 0;
            FactoryButton.Text = "Factory";
            FactoryButton.UseVisualStyleBackColor = true;
            FactoryButton.Click += FactoryButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 121);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "Cook label";
            // 
            // VegeRecipeButton
            // 
            VegeRecipeButton.BackColor = Color.PaleGreen;
            VegeRecipeButton.Location = new Point(92, 218);
            VegeRecipeButton.Name = "VegeRecipeButton";
            VegeRecipeButton.Size = new Size(136, 34);
            VegeRecipeButton.TabIndex = 2;
            VegeRecipeButton.Text = "Vege Recipe";
            VegeRecipeButton.UseVisualStyleBackColor = false;
            VegeRecipeButton.Click += VegeRecipeButton_Click;
            // 
            // PatternsTest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VegeRecipeButton);
            Controls.Add(label1);
            Controls.Add(FactoryButton);
            Name = "PatternsTest";
            Text = "PatternsTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FactoryButton;
        private Label label1;
        private Button VegeRecipeButton;
    }
}