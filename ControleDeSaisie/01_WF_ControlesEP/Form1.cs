using _01_CL_Achat;
using _01_CL_Api_Client;
using _01_CL_RegleDeControle;
using _01_WF_Validation;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json;

namespace _01_WF_ControlesEP
{
    public partial class Form1 : Form
    {
        private static int compteur = 0;

        private DateTime dateValidee;
        private decimal montantValide;


        public Form1()
        {
            InitializeComponent();
            compteur++;
            this.Text = "Les contrôles N°" + compteur;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) // The upper right "X" was clicked
            {
                AutoValidate = AutoValidate.Disable; //Deactivate all validations
            }
            base.WndProc(ref m);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Fin de l'application",
                                                "FIN",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Btn_Effacer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Vider le formulaire ?",
                                                "Effacer le formulaire",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Information,
                                                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                textBox_Nom.Clear();
                textBox_Date.Clear();
                textBox_Montant.Clear();
                textBox_CodePostal.Clear();
            }
        }

        private void TextBox_Nom_Validating(object sender, CancelEventArgs e)
        {
            if (BoiteAOutilDeRegles.IsStartingSpace(textBox_Nom.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Pas d'espace avant le nom");
            }
            else if (BoiteAOutilDeRegles.IsEndingSpace(textBox_Nom.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Pas d'espace après le nom");
            }
            else if (BoiteAOutilDeRegles.IsEmpty(textBox_Nom.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Vous devez renseigner un nom");
            }
            else if (BoiteAOutilDeRegles.IsMoreThan30(textBox_Nom.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Le nom doit ne doit pas dépasser 30 caractères");
            }
            else if (BoiteAOutilDeRegles.IsNameLessThan2(textBox_Nom.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Le nom doit faire plus de 2 caractères");
            }
            else if (BoiteAOutilDeRegles.IsNameNotAlphabetic(textBox_Nom.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Merci de ne renseigner que des caractères autorisés (Minuscules, Majuscules, -, ',  .");
            }
        }

        private void TextBox_Date_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (BoiteAOutilDeRegles.IsStartingSpace(textBox_Date.Text))
                {
                    errorProviderDate.SetError(textBox_Date, "Il ne doit pas y avoir d'espaces avant la date");
                }
                else if (BoiteAOutilDeRegles.IsEndingSpace(textBox_Date.Text))
                {
                    errorProviderDate.SetError(textBox_Date, "Pas d'espace après la date");
                }
                else if (BoiteAOutilDeRegles.IsEmpty(textBox_Date.Text))
                {
                    errorProviderDate.SetError(textBox_Date, "Vous devez renseigner une date");
                }
                else if (!BoiteAOutilDeRegles.IsDateFormatValid(textBox_Date.Text, out dateValidee))
                {
                    errorProviderDate.SetError(textBox_Date, "Vous devez renseigner une date valide");
                }
                else if (BoiteAOutilDeRegles.IsDateInPast(dateValidee))
                {
                    errorProviderDate.SetError(textBox_Date, "La date ne doit pas être dans le passé");
                }
                else
                {
                    errorProviderDate.SetError(textBox_Date, "");
                }
            }
            catch
            {
                errorProviderDate.SetError(textBox_Date, "Saisie invalide");
            }
        }

        private void TextBox_Montant_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (BoiteAOutilDeRegles.IsStartingSpace(textBox_Montant.Text))
                {
                    e.Cancel = true;
                    errorProviderMontant.SetError(textBox_Montant, "Il ne doit pas y avoir d'espaces avant le montant");
                }
                else if (BoiteAOutilDeRegles.IsEndingSpace(textBox_Montant.Text))
                {
                    e.Cancel = true;
                    errorProviderMontant.SetError(textBox_Montant, "Pas d'espace après le montant");
                }
                else if (BoiteAOutilDeRegles.IsEmpty(textBox_Montant.Text))
                {
                    e.Cancel = true;
                    errorProviderMontant.SetError(textBox_Montant, "Vous devez renseigner un montant");
                }
                else if (BoiteAOutilDeRegles.IsMoreThan20(textBox_Montant.Text))
                {
                    e.Cancel = true;
                    errorProviderMontant.SetError(textBox_Montant, "Le montant renseigné ne doit pas dépasser 20 caractères");
                }
                else if (BoiteAOutilDeRegles.IsAmountNegative(textBox_Montant.Text))
                {
                    e.Cancel = true;
                    errorProviderMontant.SetError(textBox_Montant, "Le montant ne doit pas être négatif");
                }
                else if (!BoiteAOutilDeRegles.IsAmountValid(textBox_Montant.Text, out montantValide))
                {
                    e.Cancel = true;
                    errorProviderMontant.SetError(textBox_Montant, "Vous devez renseigner un montant valide");
                }
                else
                {
                    errorProviderMontant.SetError(textBox_Montant, "");
                }
            }
            catch
            {
                e.Cancel = true;
                errorProviderMontant.SetError(textBox_Montant, "Saisie invalide");
            }
        }

        private void TextBox_CodePostal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (BoiteAOutilDeRegles.IsStartingSpace(textBox_CodePostal.Text))
                {
                    e.Cancel = true;
                    errorProviderCodePostal.SetError(textBox_CodePostal, "Il ne doit pas y avoir d'espaces avant le code postal");
                }
                else if (BoiteAOutilDeRegles.IsEndingSpace(textBox_CodePostal.Text))
                {
                    e.Cancel = true;
                    errorProviderCodePostal.SetError(textBox_CodePostal, "Pas d'espace après le code postal");
                }
                else if (BoiteAOutilDeRegles.IsEmpty(textBox_CodePostal.Text))
                {
                    e.Cancel = true;
                    errorProviderCodePostal.SetError(textBox_CodePostal, "Vous devez renseigner un code postal");
                }
                else if (!BoiteAOutilDeRegles.IsCodePostalValid(textBox_CodePostal.Text))
                {
                    e.Cancel = true;
                    errorProviderCodePostal.SetError(textBox_CodePostal, "Vous devez renseigner un code postal valide");
                }
                else
                {
                    errorProviderCodePostal.SetError(textBox_CodePostal, "");
                }
            }
            catch
            {
                e.Cancel = true;
                errorProviderCodePostal.SetError(textBox_CodePostal, "Saisie invalide");
            }
        }

        private async void Btn_Valider_Click(object sender, EventArgs e)
        {
            // Vérifie que tous les champs sont valides.
            if (this.ValidateChildren())
            {
                Achat nouvelAchat = new Achat(textBox_Nom.Text, dateValidee, montantValide, textBox_CodePostal.Text);

                /* string monJson = JsonSerializer.Serialize<Achat>(nouvelAchat);

                 Uri result = await ApiClient.CreateAchatAsyncFromJson(monJson);
 */
                // requête POST vers l'API
                Uri result = await ApiClient.CreateAchatAsync(nouvelAchat);


                Form_validation validation = new Form_validation(nouvelAchat);
                validation.ShowDialog();
            }
            else
            {
                // Si la validation échoue, les ErrorProviders seront affichés automatiquement
                MessageBox.Show("Veuillez corriger les erreurs sur le formulaire.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListe fListe = new FormListe();
            fListe.ShowDialog();

        }

        //private void AfficherErreur(Control controle, ErrorProvider provider, string messageErreur, CancelEventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(messageErreur))
        //    {
        //        e.Cancel = true;
        //        provider.SetError(controle, messageErreur);
        //    }
        //    else
        //    {
        //        provider.SetError(controle, string.Empty); // Efface l'erreur si tout est valide
        //    }
        //}
    }
}

