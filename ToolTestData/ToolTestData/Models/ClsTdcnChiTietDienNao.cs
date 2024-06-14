using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsTdcnChiTietDienNao
{
    public int MaSoChiTietPhieuDienNao { get; set; }

    public string MaPhieuKetQua { get; set; } = null!;

    public string SoCap { get; set; } = null!;

    public int MaSoPhieuChiDinh { get; set; }

    public DateTime GioTiepNhan { get; set; }

    public DateTime GioThucHien { get; set; }

    public int MaKhoaThucHien { get; set; }

    public int MaBsdocKetQua { get; set; }

    public int KtvthucHien { get; set; }

    public int MaSoClsthuocCuaBn { get; set; }

    public int MaThietBi { get; set; }

    public int MaSoMauKetQua { get; set; }

    public string MoTaKetQua { get; set; } = null!;

    public string KetLuan { get; set; } = null!;

    public string DeNghi { get; set; } = null!;

    public DateTime InLanDau { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
