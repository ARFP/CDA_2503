namespace _01_WF_Validation
{
    partial class Form_validation
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
            button1 = new Button();
            label_Nom = new Label();
            label_Date = new Label();
            label_Montant = new Label();
            label_CodePostal = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(78, 100);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_Nom
            // 
            label_Nom.AutoSize = true;
            label_Nom.Location = new Point(12, 23);
            label_Nom.Name = "label_Nom";
            label_Nom.Size = new Size(43, 15);
            label_Nom.TabIndex = 2;
            label_Nom.Text = "Nom : ";
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Location = new Point(12, 38);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(40, 15);
            label_Date.TabIndex = 3;
            label_Date.Text = "Date : ";
            // 
            // label_Montant
            // 
            label_Montant.AutoSize = true;
            label_Montant.Location = new Point(12, 53);
            label_Montant.Name = "label_Montant";
            label_Montant.Size = new Size(62, 15);
            label_Montant.TabIndex = 4;
            label_Montant.Text = "Montant : ";
            // 
            // label_CodePostal
            // 
            label_CodePostal.AutoSize = true;
            label_CodePostal.Location = new Point(12, 68);
            label_CodePostal.Name = "label_CodePostal";
            label_CodePostal.Size = new Size(79, 15);
            label_CodePostal.TabIndex = 5;
            label_CodePostal.Text = "Code Postal : ";
            // 
            // Form_validation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 141);
            Controls.Add(label_CodePostal);
            Controls.Add(label_Montant);
            Controls.Add(label_Date);
            Controls.Add(label_Nom);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(250, 180);
            MinimizeBox = false;
            MinimumSize = new Size(250, 180);
            Name = "Form_validation";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Validation effectuée";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label_Nom;
        private Label label_Date;
        private Label label_Montant;
        private Label label_CodePostal;
    }
}
