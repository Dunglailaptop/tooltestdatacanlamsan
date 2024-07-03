using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class HoSoXuatNhapVien
{
    public int MaSoHoSoXuatNhapVien { get; set; }

    public string MaHoSoXuatNhapVien { get; set; } = null!;

    public int MaBenhNhan { get; set; }

    public DateTime NgayVao { get; set; }

    public DateTime NgayRa { get; set; }

    public int MaKhoaDauTien { get; set; }

    public int MaKhoaCuoiCung { get; set; }

    public int TrangThai { get; set; }

    public int MaBacSi { get; set; }
}
