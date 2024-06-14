using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NhanVien
{
    public int MaSoNhanVien { get; set; }

    public string MaNhanVien { get; set; } = null!;

    public string HoVaTen { get; set; } = null!;

    public string BiDanh { get; set; } = null!;

    public int GioiTinh { get; set; }

    public DateTime? NgaySinh { get; set; }

    public int MaDiaChi { get; set; }

    public string Email { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public int MaLoaiNhanVien { get; set; }

    public int MaBangCap { get; set; }

    public int LoaiHopDong { get; set; }

    public string MoTa { get; set; } = null!;

    public string MaSoChungChiHanhNghe { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
