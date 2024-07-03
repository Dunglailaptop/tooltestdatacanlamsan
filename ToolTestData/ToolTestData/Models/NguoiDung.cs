using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NguoiDung
{
    public int MaSoNguoiDung { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public int MaNhanVien { get; set; }

    public bool TaiKhoanCuaKhoa { get; set; }

    public int MaNhomNguoiDung { get; set; }

    public string? HinhAnh { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int NguoiTao { get; set; }

    public int NguoiCapNhat { get; set; }
}
