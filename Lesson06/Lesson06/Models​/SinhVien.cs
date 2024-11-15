using System;
using System.Collections.Generic;

namespace Lesson06.Models​;

public partial class SinhVien
{
    public string MaSv { get; set; } = null!;

    public string HoSv { get; set; } = null!;

    public string TenSv { get; set; } = null!;

    public bool Phai { get; set; }

    public DateTime NgaySinh { get; set; }

    public string NoiSinh { get; set; } = null!;

    public string MaKh { get; set; } = null!;

    public double? HocBong { get; set; }

    public double? DiemTrungBinh { get; set; }

    public virtual ICollection<Ketqua> Ketquas { get; set; } = new List<Ketqua>();

    public virtual Khoa MaKhNavigation { get; set; } = null!;
}
