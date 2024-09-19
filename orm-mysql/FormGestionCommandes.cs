using orm_mysql.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace orm_mysql
{
    public partial class FormGestionCommandes : Form
    {
        public FormGestionCommandes()
        {
            InitializeComponent();
        }

        private void FormGestionCommandes_Load(object sender, EventArgs e)
        {
            cbClients.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cbClients.DisplayMember = "NOMCLI";
            bsGestion.DataSource = Modele.listeClients();
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
            bsGestion.DataSource = Modele.AjoutCommande(Convert.ToInt32(txt_montant.Text), dateTimePicker1.Value, Convert.ToInt32(cbClients.SelectedValue) );
            this.Hide();
            listeCommande listeCommande = new listeCommande();
            listeCommande.Show();
            MessageBox.Show("Ajout réussi");
        }
    }
}
