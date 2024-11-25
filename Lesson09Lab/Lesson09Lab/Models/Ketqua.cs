using System;
using System.Collections.Generic;

namespace Lesson09Lab.Models;

public partial class Ketqua
{
    public string MaSv { get; set; } = null!;

    public string MaMh { get; set; } = null!;

    public float? Diem { get; set; }

    public virtual MonHoc MaMhNavigation { get; set; } = null!;

    public virtual SinhVien MaSvNavigation { get; set; } = null!;
}
