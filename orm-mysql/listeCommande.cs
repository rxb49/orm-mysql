using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace orm_mysql
{
    public partial class listeCommande : Form
    {
        private decimal montantMini;
        public listeCommande()
        {
            InitializeComponent();
        }

        private void listeCommande_Load(object sender, EventArgs e)
        {
            bsCommande.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli

            });
            dgvCommande.DataSource = bsCommande;

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

        private void bsClients2_CurrentChanged(object sender, EventArgs e)
        {
            // récupération de l’identifiant du client issu de la comboBox : on a NUMCLI en ValueMember de la
            // combo, donc on peut récupérer la valeur par la propriété SelectedValue
            int IDC = Convert.ToInt32(cbClients.SelectedValue);
            int IdClient = Convert.ToInt32(cbClients.SelectedValue);
            bsCommande.DataSource = Modele.listeCommandesParClient(IdClient).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            })
            .OrderBy(x => x.Datecde);
            dgvCommande.DataSource = bsCommande;
        }

        private void btn_afficherTout_Click(object sender, EventArgs e)
        {
            bsCommande.DataSource = Modele.listeCommande().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli

            });
            dgvCommande.DataSource = bsCommande;
        }

        private void nmMontant_ValueChanged(object sender, EventArgs e)
        {
            decimal montantMini = nmMontant.Value;

            bsCommande.DataSource = Modele.listeCommandesParMontant(montantMini).Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli

            });
            dgvCommande.DataSource = bsCommande;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionCommandes FormGestionCommande = new FormGestionCommandes();
            FormGestionCommande.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            System.Type type = bsCommande.Current.GetType();
            int idCommande = (int)type.GetProperty("NUMCDE").GetValue(bsCommande.Current, null);
            FormGestionCommandes FormGestionCommande = new FormGestionCommandes();
            FormGestionCommande.Show();
        }
    }
}
