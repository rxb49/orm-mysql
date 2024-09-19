using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orm_mysql
{
    public partial class menuFormulaire : Form
    {
        public menuFormulaire()
        {
            InitializeComponent();
        }


        private void listeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            listeClients listeClient = new listeClients();
            listeClient.Show();
        }

        private void listeCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            listeCommande listeCommandes = new listeCommande();
            listeCommandes.Show();
        }

        private void listeStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            listePartitions listePartition = new listePartitions();
            listePartition.Show();
        }

        private void menuFormulaire_Load(object sender, EventArgs e)
        {

        }
    }
}
