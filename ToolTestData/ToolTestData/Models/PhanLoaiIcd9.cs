using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class PhanLoaiIcd9
{
    public int MaSoPhanLoaiIcd9 { get; set; }

    public string MaPhanLoaiIcd9 { get; set; } = null!;

    public string TenTiengViet { get; set; } = null!;

    public string TenTiengAnh { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
