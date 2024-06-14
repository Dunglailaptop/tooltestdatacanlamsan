using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaChiTietPhieuSieuAmTim
{
    public int MaSoChiTietPhieuSieuAmTim { get; set; }

    public string MaChiTietPhieuSieuAmTim { get; set; } = null!;

    public bool TaiGiuong { get; set; }

    public DateTime GioTiepNhan { get; set; }

    public DateTime GioThucHien { get; set; }

    public DateTime InLanDau { get; set; }

    public int MaSoCaChup { get; set; }

    public int MaSoPhieu { get; set; }

    public int NoiThucHien { get; set; }

    public int BacSiDocKq { get; set; }

    public int KtvthucHien { get; set; }

    public int MaSoMauKetQua { get; set; }

    public int MaSoThietBi { get; set; }

    public int MaSoMoTaHinhAnh { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
