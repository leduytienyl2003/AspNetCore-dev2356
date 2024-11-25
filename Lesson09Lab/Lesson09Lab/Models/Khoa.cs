using System;
using System.Collections.Generic;

namespace Lesson09Lab.Models;

public partial class Khoa
{
    public string MaKh { get; set; } = null!;

    public string TenKh { get; set; } = null!;

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
