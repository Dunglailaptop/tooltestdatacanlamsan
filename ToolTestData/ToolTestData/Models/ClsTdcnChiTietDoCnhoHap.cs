using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsTdcnChiTietDoCnhoHap
{
    public int MaSoChiTietDoCnhoHap { get; set; }

    public string MaChiTietDoCnhoHap { get; set; } = null!;

    public int MaSoPhieuChiDinh { get; set; }

    public int NoiThucHien { get; set; }

    public int BsdocKetQua { get; set; }

    public int KtvthucHien { get; set; }

    public DateTime GioTiepNhan { get; set; }

    public DateTime GioThucHien { get; set; }

    public int MauKetQua { get; set; }

    public int MaThietBi { get; set; }

    public int MaSoClsthuocCuaBn { get; set; }
}
