using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("PhongBan")]
public partial class PhongBan
{
    [Key]
    [Column("MAPB")]
    [StringLength(7)]
    public string Mapb { get; set; } = null!;

    [Column("TENPB")]
    [StringLength(50)]
    public string Tenpb { get; set; } = null!;

    [InverseProperty("MapbNavigation")]
    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
