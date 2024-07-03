using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class HuongDan
{
    public int MaSoHuongDan { get; set; }

    public string MaHuongDan { get; set; } = null!;

    public string TenHuongDan { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public bool CoHieuLuc { get; set; }

    public string TapTin { get; set; } = null!;

    public int UuTien { get; set; }

    public int MaSoLoaiDichVu { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
