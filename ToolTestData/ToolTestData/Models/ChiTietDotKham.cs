using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ChiTietDotKham
{
    public int MaChiTietDotKham { get; set; }

    public int MaDotKham { get; set; }

    public int MaBacSi { get; set; }

    public int MaDichVu { get; set; }

    public int SoLuong { get; set; }

    public bool DaIn { get; set; }

    public DateTime? NgayIn { get; set; }

    public bool DaTraTien { get; set; }

    public string GhiChu { get; set; } = null!;

    public int Huy { get; set; }

    public int TrangThaiCls { get; set; }

    public int MaCa { get; set; }

    public int MaHangCho { get; set; }

    public int LoaiGia { get; set; }

    public bool BaoHiemYte { get; set; }

    public DateTime ThoiGianTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int NguoiTao { get; set; }

    public int NguoiCapNhat { get; set; }
}
