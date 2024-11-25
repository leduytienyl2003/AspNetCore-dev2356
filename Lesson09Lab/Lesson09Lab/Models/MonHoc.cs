using System;
using System.Collections.Generic;

namespace Lesson09Lab.Models;

public partial class MonHoc
{
    public string MaMh { get; set; } = null!;

    public string TenMh { get; set; } = null!;

    public byte? Sotiet { get; set; }

    public virtual ICollection<Ketqua> Ketquas { get; set; } = new List<Ketqua>();
}
