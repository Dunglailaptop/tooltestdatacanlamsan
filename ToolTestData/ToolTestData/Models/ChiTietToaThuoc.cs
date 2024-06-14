using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ChiTietToaThuoc
{
    public int MaSoChiTietToaThuoc { get; set; }

    public int MaSoToaThuoc { get; set; }

    public int MaSoThuoc { get; set; }

    public double Sang { get; set; }

    public double Trua { get; set; }

    public double Chieu { get; set; }

    public double Toi { get; set; }

    public int DongGoi { get; set; }

    public int SoNgay { get; set; }

    public int SoLanNgay { get; set; }

    public int SoLuongMotLan { get; set; }

    public int TongCong { get; set; }

    public string? HuongDan { get; set; }

    public int LieuDung { get; set; }

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
