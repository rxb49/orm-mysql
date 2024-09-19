using orm_mysql.Entities;
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
    public partial class listePartitions : Form
    {
        public listePartitions()
        {
            InitializeComponent();
        }

        private void listeStyle_Load(object sender, EventArgs e)
        {
            bsStyle.DataSource = Modele.listePartitions().Select(x => new
            {
                x.Numpart,
                x.Libpart,
                x.Prixpart,
                x.Numstyle,

            });
            dgvPartitions.DataSource = bsStyle;

            cbPartitions.ValueMember = "NUMSTYLE"; //permet de stocker l'identifiant
            cbPartitions.DisplayMember = "LIBSTYLE";
            bsStyle2.DataSource = Modele.listeStyle();
            cbPartitions.DataSource = bsStyle2;
        }

        private void bsStyle2_CurrentChanged(object sender, EventArgs e)
        {
            // récupération de l’identifiant du client issu de la comboBox : on a NUMCLI en ValueMember de la
            // combo, donc on peut récupérer la valeur par la propriété SelectedValue
            int IdStyle = Convert.ToInt32(cbPartitions.SelectedValue);
            bsStyle2.DataSource = Modele.listePartitionsParStyle(IdStyle).Select(x => new
            {
                x.Numpart,
                x.Libpart,
                x.Prixpart,
                x.Numstyle,
            })
            .OrderBy(x => x.Numstyle);
            dgvPartitions.DataSource = bsStyle;
        }
    }
}
