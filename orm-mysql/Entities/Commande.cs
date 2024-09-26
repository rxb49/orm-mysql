namespace orm_mysql.Entities;

public partial class Commande
{
    public int Numcli { get; set; }

    public int Numcde { get; set; }

    public DateTime? Datecde { get; set; }

    public int? Montantcde { get; set; }

    public virtual Client NumcliNavigation { get; set; } = null!;

    public virtual ICollection<Partition> Numparts { get; set; } = new List<Partition>();
}
