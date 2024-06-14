using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NhomDuocLy
{
    public int MaSoNhomDuocLy { get; set; }

    public string MaNhomDuocLy { get; set; } = null!;

    public string TenTiengViet { get; set; } = null!;

    public string TenTiengAnh { get; set; } = null!;

    public int Loai { get; set; }

    public string GhiChu { get; set; } = null!;

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
