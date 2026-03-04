using _01_CL_Achat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_CL_Api_Client;
using System.Diagnostics;

namespace _01_WF_Validation
{
    public partial class FormListe : Form
    {

        private List<Achat> achats;

        public FormListe()
        {
            achats = new();
            InitializeComponent();
            this.Load += Form_Load;
        }

        public async void Form_Load(object? sender, EventArgs args)
        {
            achats = await ApiClient.GetAchatsAsync();

            bindingSource1.DataSource = achats;

            dataGridView1.DataSource = bindingSource1;

            // Ne pas afficher la 1ere colonne
            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].HeaderText = "TOTO";

            dataGridView1.CellDoubleClick += Cell_DoubleClick;
        }

        public async void Cell_DoubleClick(object? sender, EventArgs args)
        {
            Debug.Write(sender);
        }
    }
}
