using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NhaCungCap
{
    public int MaSoNhaCungCap { get; set; }

    public string MaNhaCungCap { get; set; } = null!;

    public string CodeNhaCungCap { get; set; } = null!;

    public string TenNhaCungCap { get; set; } = null!;

    public string MaSoThue { get; set; } = null!;

    public string MaHoaDon { get; set; } = null!;

    public string KiHieuHoaDon { get; set; } = null!;

    public string DienThoai { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string WebSite { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public int MaQuocGia { get; set; }

    public string TenQuocGiaTiengViet { get; set; } = null!;

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? MaNguoiTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }
}
