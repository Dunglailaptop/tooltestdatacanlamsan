using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmPhieuDangKyMau
{
    public int MaSoPhieuDangKyMau { get; set; }

    public string MaPhieuDangKyMau { get; set; } = null!;

    public int MaSoLoaiChePham { get; set; }

    public int MaSoTuiMau { get; set; }

    public DateTime GioDangKy { get; set; }

    public int NguoiDangKy { get; set; }

    public int TrangThaiDkm { get; set; }

    public int TranhThaiYeuCauLinh { get; set; }

    public int MaSoChiTietXn { get; set; }

    public int NhanVienXn { get; set; }

    public int Can { get; set; }

    public int MaSoPhieuNoiTru { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
