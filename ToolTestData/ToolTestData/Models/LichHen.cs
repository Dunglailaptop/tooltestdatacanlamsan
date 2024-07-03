using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class LichHen
{
    public int MaLichHen { get; set; }

    public string TenBenhNhan { get; set; } = null!;

    public DateTime NgaySinh { get; set; }

    public int GioiTinh { get; set; }

    public DateTime ThoiGianKham { get; set; }

    public string SdtDangKy { get; set; } = null!;

    public int MaPhong { get; set; }

    public string? YeuCau { get; set; }

    public string? GhiChu { get; set; }

    public int MaDotKham { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
