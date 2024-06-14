using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class HangSanXuat
{
    public int MaSoHangSanXuat { get; set; }

    public string MaHangSanXuat { get; set; } = null!;

    public string TenHangSanXuat { get; set; } = null!;

    public string DienThoai { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public int MaQuocGia { get; set; }

    public string TenQuocGiaTiengViet { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Website { get; set; } = null!;

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
