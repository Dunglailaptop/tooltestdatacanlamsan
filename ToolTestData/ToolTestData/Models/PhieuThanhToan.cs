using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class PhieuThanhToan
{
    public int MaPhieuThanhToan { get; set; }

    public string MaHoaDonThanhToan { get; set; } = null!;

    public DateTime NgayTao { get; set; }

    public int NguoiThuTien { get; set; }

    public decimal TongTien { get; set; }

    public string GhiChu { get; set; } = null!;

    public int MaHoaDonDienTu { get; set; }

    public int HinhThucThanhToan { get; set; }

    public int LoaiHoaDon { get; set; }

    public bool HoanTienLai { get; set; }

    public bool Xoa { get; set; }

    public string SoHoaDon { get; set; } = null!;

    public string ThongTinHoaDon { get; set; } = null!;
}
