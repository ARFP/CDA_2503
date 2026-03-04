namespace _01_WF_ControlesEP
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
            components = new System.ComponentModel.Container();
            label_Nom = new Label();
            label_Date = new Label();
            label_Montant = new Label();
            label_CodePostal = new Label();
            label_DateFormat = new Label();
            textBox_Nom = new TextBox();
            textBox_Date = new TextBox();
            textBox_Montant = new TextBox();
            textBox_CodePostal = new TextBox();
            btn_Valider = new Button();
            btn_Effacer = new Button();
            errorProviderDate = new ErrorProvider(components);
            errorProviderMontant = new ErrorProvider(components);
            errorProviderCodePostal = new ErrorProvider(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCodePostal).BeginInit();
            SuspendLayout();
            // 
            // label_Nom
            // 
            label_Nom.AutoSize = true;
            label_Nom.Location = new Point(12, 29);
            label_Nom.Name = "label_Nom";
            label_Nom.Size = new Size(34, 15);
            label_Nom.TabIndex = 0;
            label_Nom.Text = "Nom";
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Location = new Point(12, 58);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(31, 15);
            label_Date.TabIndex = 1;
            label_Date.Text = "Date";
            // 
            // label_Montant
            // 
            label_Montant.AutoSize = true;
            label_Montant.Location = new Point(12, 87);
            label_Montant.Name = "label_Montant";
            label_Montant.Size = new Size(53, 15);
            label_Montant.TabIndex = 4;
            label_Montant.Text = "Montant";
            // 
            // label_CodePostal
            // 
            label_CodePostal.AutoSize = true;
            label_CodePostal.Location = new Point(12, 116);
            label_CodePostal.Name = "label_CodePostal";
            label_CodePostal.Size = new Size(70, 15);
            label_CodePostal.TabIndex = 6;
            label_CodePostal.Text = "Code Postal";
            // 
            // label_DateFormat
            // 
            label_DateFormat.AutoSize = true;
            label_DateFormat.Location = new Point(248, 58);
            label_DateFormat.Name = "label_DateFormat";
            label_DateFormat.Size = new Size(87, 15);
            label_DateFormat.TabIndex = 1;
            label_DateFormat.Text = "(JJ/MM/AAAA)";
            // 
            // textBox_Nom
            // 
            textBox_Nom.Location = new Point(91, 26);
            textBox_Nom.MaxLength = 30;
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.Size = new Size(179, 23);
            textBox_Nom.TabIndex = 0;
            textBox_Nom.Tag = "Nom";
            textBox_Nom.Validating += TextBox_Nom_Validating;
            // 
            // textBox_Date
            // 
            textBox_Date.Location = new Point(91, 55);
            textBox_Date.MaxLength = 10;
            textBox_Date.Name = "textBox_Date";
            textBox_Date.Size = new Size(133, 23);
            textBox_Date.TabIndex = 1;
            textBox_Date.Tag = "Date";
            textBox_Date.Validating += TextBox_Date_Validating;
            // 
            // textBox_Montant
            // 
            textBox_Montant.Location = new Point(91, 84);
            textBox_Montant.MaxLength = 20;
            textBox_Montant.Name = "textBox_Montant";
            textBox_Montant.Size = new Size(133, 23);
            textBox_Montant.TabIndex = 2;
            textBox_Montant.Tag = "Montant";
            textBox_Montant.Validating += TextBox_Montant_Validating;
            // 
            // textBox_CodePostal
            // 
            textBox_CodePostal.Location = new Point(91, 113);
            textBox_CodePostal.MaxLength = 5;
            textBox_CodePostal.Name = "textBox_CodePostal";
            textBox_CodePostal.Size = new Size(100, 23);
            textBox_CodePostal.TabIndex = 3;
            textBox_CodePostal.Tag = "Code";
            textBox_CodePostal.Validating += TextBox_CodePostal_Validating;
            // 
            // btn_Valider
            // 
            btn_Valider.Location = new Point(277, 112);
            btn_Valider.Name = "btn_Valider";
            btn_Valider.Size = new Size(75, 23);
            btn_Valider.TabIndex = 4;
            btn_Valider.Text = "Valider";
            btn_Valider.UseVisualStyleBackColor = true;
            btn_Valider.Click += Btn_Valider_Click;
            // 
            // btn_Effacer
            // 
            btn_Effacer.CausesValidation = false;
            btn_Effacer.Location = new Point(277, 141);
            btn_Effacer.Name = "btn_Effacer";
            btn_Effacer.Size = new Size(75, 23);
            btn_Effacer.TabIndex = 5;
            btn_Effacer.Text = "Effacer";
            btn_Effacer.UseVisualStyleBackColor = true;
            btn_Effacer.Click += Btn_Effacer_Click;
            // 
            // errorProviderDate
            // 
            errorProviderDate.ContainerControl = this;
            // 
            // errorProviderMontant
            // 
            errorProviderMontant.ContainerControl = this;
            // 
            // errorProviderCodePostal
            // 
            errorProviderCodePostal.ContainerControl = this;
            // 
            // button1
            // 
            button1.CausesValidation = false;
            button1.Location = new Point(12, 164);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Liste";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(401, 189);
            Controls.Add(button1);
            Controls.Add(btn_Effacer);
            Controls.Add(btn_Valider);
            Controls.Add(textBox_CodePostal);
            Controls.Add(textBox_Montant);
            Controls.Add(textBox_Date);
            Controls.Add(textBox_Nom);
            Controls.Add(label_DateFormat);
            Controls.Add(label_CodePostal);
            Controls.Add(label_Montant);
            Controls.Add(label_Date);
            Controls.Add(label_Nom);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Les Contrôles";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCodePostal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Nom;
        private Label label_Date;
        private Label label_Montant;
        private Label label_CodePostal;
        private Label label_DateFormat;
        private TextBox textBox_Nom;
        private TextBox textBox_Date;
        private TextBox textBox_Montant;
        private TextBox textBox_CodePostal;
        private Button btn_Valider;
        private Button btn_Effacer;
        private ErrorProvider errorProviderDate;
        private ErrorProvider errorProviderMontant;
        private ErrorProvider errorProviderCodePostal;
        private Button button1;
    }
}
