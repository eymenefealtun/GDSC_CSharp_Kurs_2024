namespace _10_MyFirstWinformsApp
{
    partial class Form1
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
            btnIncrease = new Button();
            labelNumber = new Label();
            btnDecrease = new Button();
            cBoxFruits = new ComboBox();
            SuspendLayout();
            // 
            // btnIncrease
            // 
            btnIncrease.BackColor = Color.Red;
            btnIncrease.Location = new Point(61, 153);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(143, 71);
            btnIncrease.TabIndex = 0;
            btnIncrease.Text = "Increase";
            btnIncrease.UseVisualStyleBackColor = false;
            btnIncrease.Click += button1_Click;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumber.Location = new Point(106, 66);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(56, 65);
            labelNumber.TabIndex = 1;
            labelNumber.Text = "0";
            // 
            // btnDecrease
            // 
            btnDecrease.BackColor = Color.FromArgb(0, 192, 192);
            btnDecrease.Location = new Point(248, 153);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(139, 71);
            btnDecrease.TabIndex = 2;
            btnDecrease.Text = "Decrease";
            btnDecrease.UseVisualStyleBackColor = false;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // cBoxFruits
            // 
            cBoxFruits.FormattingEnabled = true;
            cBoxFruits.Location = new Point(457, 108);
            cBoxFruits.Name = "cBoxFruits";
            cBoxFruits.Size = new Size(121, 23);
            cBoxFruits.TabIndex = 3;
            cBoxFruits.SelectedIndexChanged += cBoxFruits_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cBoxFruits);
            Controls.Add(btnDecrease);
            Controls.Add(labelNumber);
            Controls.Add(btnIncrease);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIncrease;
        private Label labelNumber;
        private Button btnDecrease;
        private ComboBox cBoxFruits;
    }
}