using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class HangChoBenhNhan
{
    public int MaSoHangChoBenhNhan { get; set; }

    public string MaHangChoBenhNhan { get; set; } = null!;

    public string TenHangChoBenhNhan { get; set; } = null!;

    public string MoTa { get; set; } = null!;

    public int ThoiGianUocLuong { get; set; }

    public int SoBenhNhanToiDa { get; set; }

    public int SoLuongBenhNhanChuanBi { get; set; }

    public int ThuTuHienThi { get; set; }

    public int SoDaGoi { get; set; }

    public int SoLonNhat { get; set; }

    public int MaSoKhuVuc { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
