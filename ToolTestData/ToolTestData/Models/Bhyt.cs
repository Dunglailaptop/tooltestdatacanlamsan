using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class Bhyt
{
    public int MaSoTheBhyt { get; set; }

    public string MaTheBhyt { get; set; } = null!;

    public int NhomBhyt { get; set; }

    public string MaVachBhyt { get; set; } = null!;

    public int MaBenhVienChuyen { get; set; }

    public string QuyenLoi { get; set; } = null!;

    public int NoiDangKyKhamChuaBenhBanDau { get; set; }

    public DateTime NgayCap { get; set; }

    public DateTime NgayHetHan { get; set; }

    public string? KhuVuc { get; set; }

    public DateTime ThoiHanDu5NamBhyt { get; set; }

    public bool Kct { get; set; }

    public DateTime KcttuNgay { get; set; }

    public DateTime KctdenNgay { get; set; }

    public int MaBenhNhan { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
