namespace orm_mysql.Entities;

public partial class Client
{
    public int Numcli { get; set; }

    public string? Nomcli { get; set; }

    public string? Prenomcli { get; set; }

    public string? Adrcli { get; set; }

    public string? Telephone { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();
}
