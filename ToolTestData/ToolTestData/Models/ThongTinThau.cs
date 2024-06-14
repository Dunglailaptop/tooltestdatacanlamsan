using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ThongTinThau
{
    public int MaSoThongTinThau { get; set; }

    public int MaHopDongThau { get; set; }

    public string? SoQuyetDinh { get; set; }

    public DateTime? NgayCongBo { get; set; }

    public bool? HoTroBhyt { get; set; }

    public decimal BhytgiaTien { get; set; }

    public decimal TyLeThanhToan { get; set; }

    public string? MaHoatChat { get; set; }

    public string? MaDuongDung { get; set; }

    public string? TenThuocBaoHiem { get; set; }

    public string? HamLuong { get; set; }

    public string? MaGoiThau { get; set; }

    public string? MaNhomThau { get; set; }

    public int? NhaThau { get; set; }

    public string? SoLuongBhyt { get; set; }

    public string? SoDangKyGpnk { get; set; }

    public bool? TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public int? MaNguoiCapNhat { get; set; }
}
