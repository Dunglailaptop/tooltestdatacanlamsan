using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DotKham
{
    public int MaSoDotKham { get; set; }

    public string MaDotKham { get; set; } = null!;

    public int MaKhoa { get; set; }

    public int MaBenhNhan { get; set; }

    public string TenDotKham { get; set; } = null!;

    public int LoaiKhamBenh { get; set; }

    public int LoaiBenhNhan { get; set; }

    public DateTime ThoiGianTao { get; set; }

    public DateTime ThoiGianBatDau { get; set; }

    public DateTime? ThoiGianKetThuc { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int NguoiTao { get; set; }

    public int NguoiCapNhat { get; set; }
}
