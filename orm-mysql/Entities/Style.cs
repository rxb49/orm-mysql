﻿namespace orm_mysql.Entities;

public partial class Style
{
    public int Numstyle { get; set; }

    public string? Libstyle { get; set; }

    public virtual ICollection<Partition> Partitions { get; set; } = new List<Partition>();
}
