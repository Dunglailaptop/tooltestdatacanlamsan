using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class Kho
{
    public int MaSoKho { get; set; }

    public string MaKho { get; set; } = null!;

    public int MaPhongBan { get; set; }

    public int MaLoaiThuocNguyenLieuYte { get; set; }

    public int CanhBaoHanDung { get; set; }

    public int CanhBaoTonToiThieu { get; set; }

    public int CapLe { get; set; }

    public string TienToPhieuNhap { get; set; } = null!;

    public string TienToPhieuXuat { get; set; } = null!;

    public int KeDonNoiVien { get; set; }

    public int SoLuongPhieuTra { get; set; }

    public int SoLuongPhieuXuat { get; set; }

    public string TenKho { get; set; } = null!;

    public int ThanhVienKiemDuyet { get; set; }

    public int NgayCaiLai { get; set; }

    public int ThangCaiLai { get; set; }

    public int NamCaiLai { get; set; }
}
