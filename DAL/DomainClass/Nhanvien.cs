using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("Nhanvien")]
public partial class Nhanvien
{
    [Column("STT")]
    public int Stt { get; set; }

    [Key]
    [Column("MANV")]
    [StringLength(7)]
    public string Manv { get; set; } = null!;

    [Column("TENNV")]
    [StringLength(50)]
    public string Tennv { get; set; } = null!;

    [Column("MAPB")]
    [StringLength(7)]
    public string Mapb { get; set; } = null!;

    [ForeignKey("Mapb")]
    [InverseProperty("Nhanviens")]
    public virtual PhongBan MapbNavigation { get; set; } = null!;
}
