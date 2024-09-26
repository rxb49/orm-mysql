namespace orm_mysql
{
    public partial class FormGestionCommandes : Form
    {
        private string mode;
        private int? idCommande;

        // Constructeur pour le mode ajout
        public FormGestionCommandes(string mode)
        {
            InitializeComponent();
            this.mode = mode;
            this.idCommande = null;
        }

        // Constructeur pour le mode modification
        public FormGestionCommandes(string mode, int idCommande)
        {
            InitializeComponent();
            this.mode = mode;
            this.idCommande = idCommande;
        }

        private void FormGestionCommandes_Load(object sender, EventArgs e)
        {
            cbClients.ValueMember = "NUMCLI"; // Permet de stocker l'identifiant
            cbClients.DisplayMember = "NOMCLI";
            bsGestion.DataSource = Modele.listeClients(); // Charger la liste des clients
            cbClients.DataSource = bsGestion;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
            listeCommande listeCommande = new listeCommande();
            listeCommande.Show();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (mode == "Ajouter")
            {
                try
                {
                    bsGestion.DataSource = Modele.AjoutCommande(
                                        Convert.ToInt32(txt_montant.Text),
                                        dateTimePicker1.Value,
                                        Convert.ToInt32(cbClients.SelectedValue)
                                    );
                    MessageBox.Show("Ajout réussi");
                }
                catch
                {
                    MessageBox.Show("Erreur lors de l\'ajout");

                }

            }
            else if (mode == "Modifier" && idCommande.HasValue)
            {
                try
                {
                    bsGestion.DataSource = Modele.ModifierCommande(
                    idCommande.Value,
                    Convert.ToInt32(txt_montant.Text),
                    dateTimePicker1.Value,
                    Convert.ToInt32(cbClients.SelectedValue));
                    MessageBox.Show("Modification réussie");
                }
                catch
                {
                    MessageBox.Show("Erreur lors de la modification");

                }

            }

            this.Hide();
            listeCommande listeCommande = new listeCommande();
            listeCommande.Show();
        }
    }
}
