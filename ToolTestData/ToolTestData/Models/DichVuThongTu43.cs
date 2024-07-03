using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DichVuThongTu43
{
    public int MaSoDichVuThongTu43 { get; set; }

    public string MaDichVuThongTu43 { get; set; } = null!;

    public string TenDichVu { get; set; } = null!;

    public decimal GiaDichVu { get; set; }

    public int QuyetDinh { get; set; }

    public DateTime NgayCongBo { get; set; }

    public string Chuong { get; set; } = null!;

    public int TuyenA { get; set; }

    public int TuyenB { get; set; }

    public int TuyenC { get; set; }

    public int TuyenD { get; set; }

    public bool HieuLuc { get; set; }

    public string GhiChu { get; set; } = null!;

    public bool GiaCoDinh { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int NguoiTao { get; set; }

    public int NguoiCapNhat { get; set; }
}
