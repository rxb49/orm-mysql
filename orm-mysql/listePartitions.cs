using System.Data;

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

                // Désactiver temporairement l'événement pour éviter la récursion
                bsStyle2.CurrentChanged -= bsStyle2_CurrentChanged;

                int IdStyle = Convert.ToInt32(cbPartitions.SelectedValue);
                bsStyle2.DataSource = Modele.listePartitionsParStyle(IdStyle)
                    .Select(x => new
                    {
                        x.Numpart,
                        x.Libpart,
                        x.Prixpart,
                        x.Numstyle,
                    })
                    .OrderBy(x => x.Numstyle);

                dgvPartitions.DataSource = bsStyle;

                // Réactiver l'événement après la mise à jour
                bsStyle2.CurrentChanged += bsStyle2_CurrentChanged;
            
        }
    }
}
