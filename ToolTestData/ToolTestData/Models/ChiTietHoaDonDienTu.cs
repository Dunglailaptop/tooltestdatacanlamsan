using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ChiTietHoaDonDienTu
{
    public int MaSoChiTietHoaDonDienTu { get; set; }

    public string MaChiTietHoaDonDienTu { get; set; } = null!;

    public int MaHoaDonDienTu { get; set; }

    public string HuongDanBkav { get; set; } = null!;

    public decimal TongTien { get; set; }

    public int TrangThai { get; set; }

    public int LoaiHoaDon { get; set; }

    public int LoaiSanPham { get; set; }

    public int NguoiTao { get; set; }

    public DateTime ThoiGianTao { get; set; }

    public string MauHoaDonDienTu { get; set; } = null!;
}
