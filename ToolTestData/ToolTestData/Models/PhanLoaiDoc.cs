using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class PhanLoaiDoc
{
    public int MaSoPhanLoaiDoc { get; set; }

    public string? MaPhanLoaiDoc { get; set; }

    public string? TenTiengViet { get; set; }

    public string? TenTiengAnh { get; set; }

    public int Mau { get; set; }

    public int Loai { get; set; }

    public string? GhiChu { get; set; }

    public bool? ThuocDoc { get; set; }

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
