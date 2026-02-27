namespace _01_WF_Validation
{
    partial class FormListe
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            achatBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montantDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codePostalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)achatBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, montantDataGridViewTextBoxColumn, codePostalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = achatBindingSource;
            dataGridView1.Location = new Point(88, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(546, 150);
            dataGridView1.TabIndex = 0;
            // 
            // achatBindingSource
            // 
            achatBindingSource.DataSource = typeof(_01_CL_Achat.Achat);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantDataGridViewTextBoxColumn
            // 
            montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            montantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            codePostalDataGridViewTextBoxColumn.HeaderText = "CodePostal";
            codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            codePostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "FormListe";
            Text = "FormListe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)achatBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private BindingSource achatBindingSource;
    }
}