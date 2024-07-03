using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaChiTietMri
{
    public int MaSoChiTietPhieuMri { get; set; }

    public string MaChiTietPhieuMri { get; set; } = null!;

    public string GhiChu { get; set; } = null!;

    public DateTime GioTiepNhan { get; set; }

    public DateTime GioThucHien { get; set; }

    public DateTime InLanDau { get; set; }

    public int MaBacSiDocKetQua { get; set; }

    public int MaBsthucTap { get; set; }

    public int KtvthucHien { get; set; }

    public int MaSoThietBi { get; set; }

    public int MaSoPhieuChiDinh { get; set; }

    public int MaSoMauKetQua { get; set; }

    public int MaSoCaChup { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
