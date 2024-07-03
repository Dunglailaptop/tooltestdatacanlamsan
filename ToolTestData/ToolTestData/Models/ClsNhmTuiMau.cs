using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmTuiMau
{
    public int MaSoTuiMau { get; set; }

    public string MaTuiMau { get; set; } = null!;

    public string TenTuiMau { get; set; } = null!;

    public int MaSoMaSanPham { get; set; }

    public int MaSoNhomMauTheoIsbt { get; set; }

    public string GhiChu { get; set; } = null!;

    public int TrangThaiTuiMau { get; set; }

    public DateTime GioNhap { get; set; }

    public DateTime HanDung { get; set; }

    public int DangOkho { get; set; }

    public bool PhieuDangKi { get; set; }

    public bool ChiTietXuat { get; set; }

    public int GiaTien { get; set; }

    public int PhiDieuChe { get; set; }

    public int PhiVanChuyen { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public int NguoiCapNhat { get; set; }

    public int NguoiTao { get; set; }
}
