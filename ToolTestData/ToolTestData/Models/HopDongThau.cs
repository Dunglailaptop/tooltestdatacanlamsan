using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class HopDongThau
{
    public int MaSoHopDongThau { get; set; }

    public string? MaHopDongThau { get; set; }

    public int MaNhaCungCap { get; set; }

    public string CodeNhaCungCap { get; set; } = null!;

    public string TenNhaCungCap { get; set; } = null!;

    public string? SoHopDongThau { get; set; }

    public int LoaiHopDongThau { get; set; }

    public string? SoQuyetDinhVanBan { get; set; }

    public DateTime? NgayHieuLuc { get; set; }

    public DateTime? NgayHetHan { get; set; }

    public DateTime? NgayKy { get; set; }

    public int NhomChiPhiBh { get; set; }

    public string? FileUrl { get; set; }

    public int TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public int? MaNguoiTao { get; set; }

    public int? MaNguoiCapNhat { get; set; }
}
