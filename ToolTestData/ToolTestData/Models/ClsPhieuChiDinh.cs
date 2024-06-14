using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsPhieuChiDinh
{
    public int MaSoPhieuChiDinh { get; set; }

    public string MaPhieuChiDinh { get; set; } = null!;

    public string ChanDoan { get; set; } = null!;

    public string ChuThich { get; set; } = null!;

    public int MaSoLoaiPhieu { get; set; }

    public int MucDoUuTien { get; set; }

    public int MaSoDaCap { get; set; }

    public int TrangThai { get; set; }

    public int MaKhoaChiDinh { get; set; }

    public int MaBacSiChiDinh { get; set; }

    public int MaSoDichVuBenhVien { get; set; }

    public int MaSoLoaiDichVu { get; set; }

    public int MaSoBenhNhan { get; set; }

    public int MaSoDotKham { get; set; }

    public DateTime GioChiDinh { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int MaSoLoaiPhieuChiDinh { get; set; }
}
