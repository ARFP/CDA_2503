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

namespace _01_WF_Validation
{
    public partial class FormListe : Form
    {

        private List<Achat> achats;

        public FormListe()
        {
            achats = new();
            InitializeComponent();
        }
    }
}
