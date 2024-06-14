using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class BenhVien
{
    public int MaSoBenhVien { get; set; }

    public string MaBenhVien { get; set; } = null!;

    public string MaBenhVienDayDu { get; set; } = null!;

    public string TenBenhVien { get; set; } = null!;

    public int DiaChi { get; set; }

    public string XepHang { get; set; } = null!;

    public string TuyenChuyenMonKyThuat { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
