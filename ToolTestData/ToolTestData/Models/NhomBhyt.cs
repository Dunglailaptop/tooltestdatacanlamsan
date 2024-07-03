using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NhomBhyt
{
    public int MaSoNhomBhyt { get; set; }

    public string MaNhomBhyt { get; set; } = null!;

    public string TenNhomBhyt { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public int NguoiTao { get; set; }

    public int NguoiCapNhat { get; set; }

    public int DoUuTien { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
