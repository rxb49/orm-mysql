namespace orm_mysql
{
    public partial class listeClients : Form
    {
        public listeClients()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bsClients.DataSource = Modele.listeClients(); // appel de la méthode listeClients
            dgvClients.DataSource = bsClients;
            dgvClients.Columns[0].HeaderText = "numero client";
            dgvClients.Columns[1].HeaderText = "nom client";
            dgvClients.Columns[2].HeaderText = "prenom client";
            dgvClients.Columns[3].HeaderText = "adresse client";


            bsClients2.DataSource = Modele.listeClients();
            cbClients.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cbClients.DisplayMember = "NOMCLI";
            bsClients2.DataSource = Modele.listeClients();
            cbClients.DataSource = bsClients2;


        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuFormulaire menuFormulaire = new menuFormulaire();
            menuFormulaire.Show();
        }

    }
}
