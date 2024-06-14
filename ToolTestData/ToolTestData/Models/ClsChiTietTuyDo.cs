using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsChiTietTuyDo
{
    public int MaSoChiTietTuyDoChiTietTuyDo { get; set; }

    public string MaChiTietTuyDo { get; set; } = null!;

    public int MaSoPhieuChiDinh { get; set; }

    public int MaSoTaiLieuDinhKem { get; set; }

    public DateTime GioTiepNhan { get; set; }

    public DateTime GioThucHien { get; set; }

    public int MaKhoaThucHien { get; set; }

    public int MaBsdocKetQua { get; set; }

    public int KtvthucHien { get; set; }

    public int MaSoMauKetQua { get; set; }

    public int MaSoThietBi { get; set; }

    public int MaSoPhieuPhauThuatThuThuat { get; set; }

    public int MaSoKetQuaTuyDo { get; set; }

    public int MaSoMoTaTieuBanMauNgoaiVi { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
