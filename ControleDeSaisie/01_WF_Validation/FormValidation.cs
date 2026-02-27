using _01_CL_Achat;
namespace _01_WF_Validation
{
    public partial class Form_validation : Form
    {
        public Form_validation(Achat achat)
        {
            InitializeComponent();
            label_Nom.Text += achat.Nom;
            label_Date.Text += achat.Date;
            label_Montant.Text += achat.Montant;
            label_CodePostal.Text += achat.CodePostal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListe fListe = new FormListe();
            fListe.Show();
            this.Close();
            // fermer la fenêtre,
            // afficher une nouvelle qui va lister tous les éléments enregistrés dans l'API

        }
    }
}
