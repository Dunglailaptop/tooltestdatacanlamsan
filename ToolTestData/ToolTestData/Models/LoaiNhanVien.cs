using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class LoaiNhanVien
{
    public int MaLoaiNhanVien { get; set; }

    public string TenTiengViet { get; set; } = null!;

    public string TenTiengAnh { get; set; } = null!;
}
