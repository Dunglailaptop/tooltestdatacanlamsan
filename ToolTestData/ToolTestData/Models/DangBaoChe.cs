using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DangBaoChe
{
    public int MaSoDangBaoChe { get; set; }

    public string TenTiengViet { get; set; } = null!;

    public string TenTiengAnh { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
