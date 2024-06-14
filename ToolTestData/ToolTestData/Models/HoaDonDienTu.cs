using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class HoaDonDienTu
{
    public int MaSoHoaDonDienTu { get; set; }

    public string MaKhoaHoaDon { get; set; } = null!;

    public string MaBenhNhan { get; set; } = null!;

    public decimal TongTien { get; set; }

    public DateTime NgayTao { get; set; }

    public int LoaiHoaDon { get; set; }

    public int SoLanXuatHoaDon { get; set; }

    public int MaNhaThuoc { get; set; }
}
