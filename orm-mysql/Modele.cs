using Microsoft.EntityFrameworkCore;
using orm_mysql.Entities;

namespace orm_mysql

{


    public static class Modele
    {
        private static TijouRobinPartitionContext monModel;
        public static void init()
        {
            monModel = new TijouRobinPartitionContext();
        }
        public static List<Client> listeClients()
        {
            return monModel.Clients.ToList();
        }
        public static List<Commande> listeCommande()
        {
            return monModel.Commandes.ToList();
        }

        public static List<Commande> listeCommandes()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).ToList();
        }

        public static List<Commande> listeCommandesParClient(int idClient)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
           idClient).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

        public static List<Commande> listeCommandesParMontant(decimal montantMini)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Montantcde >=
           montantMini).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

        public static List<Partition> listePartitions()
        {
            return monModel.Partitions.ToList();
        }

        public static List<Partition> listePartitionsParStyle(int numstyle)
        {
            List<Partition> lesPartitions = monModel.Partitions.Where(s => s.Numstyle ==
           numstyle).Include(s => s.NumstyleNavigation).ToList();
            return lesPartitions;
        }

        public static List<Style> listeStyle()
        {
            return monModel.Styles.ToList();
        }

        public static bool AjoutCommande(int montant, DateTime dateC, int idClient)
        {
            Commande maCommande;
            bool vretour = true;
            try
            {
                maCommande = new Commande();
                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = dateC.Date; // la propriété DateCde doit être en DateTime dans la BD et dans la classe Commande, modifier si besoin.
                maCommande.Numcli = idClient;
                // ajout de l’objet : correspond à un insert
                monModel.Commandes.Add(maCommande);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show("Erreur lors de l\'ajout");
            }
            return vretour;
        }

        public static Commande RecupererCommande(int idCommande)
        {
            Commande uneCommande = new Commande();
            try
            {
                uneCommande = monModel.Commandes.Include(c => c.Numparts).First(x =>
               x.Numcde == idCommande);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCommande;
        }

        public static bool ModifierCommande(int idCde, int montant, DateTime dateC, int idClient)
        {
            Commande maCommande = RecupererCommande(idCde);
            bool vretour = true;
            try
            {
                maCommande.Montantcde = montant;
                maCommande.Datecde = dateC.Date;
                maCommande.Numcli = idClient;

                monModel.SaveChanges();

            }
            catch
            {
                vretour = false;
                MessageBox.Show("Erreur lors de la modification");
            }


            return vretour;
        }

        public static bool SuppCommande(int idCommande)
        {
            bool vretour = true;
            if (MessageBox.Show("Etes vous sur de vouloir supprimer la commande :" + idCommande, "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    Commande maCommande = RecupererCommande(idCommande);
                    monModel.Commandes.Remove(maCommande); // correspond au DELETE 
                    monModel.SaveChanges();

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    vretour = false;
                }
            }

            return vretour;
        }

        public static ICollection<Partition> listePartitionsParCommande(int idC)
        {
            Commande maCommande = RecupererCommande(idC);
            ICollection<Partition> part = new List<Partition>();
            part = maCommande.Numparts;
            return part;
        }
    }

}
