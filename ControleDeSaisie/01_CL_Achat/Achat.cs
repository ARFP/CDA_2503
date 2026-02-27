namespace _01_CL_Achat
{
    public class Achat
    {
        private string id;
        private string nom;
        private DateTime date;
        private decimal montant;
        private string codePostal;

        public Achat(string nom, DateTime date, decimal montant, string codePostal)
        {
            this.id = "";
            this.nom = nom;
            this.date = date;
            this.montant = montant;
            this.codePostal = codePostal;
        }

        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime Date { get => date; set => date = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
    }
}
