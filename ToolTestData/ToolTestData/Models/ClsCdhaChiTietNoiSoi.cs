using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsCdhaChiTietNoiSoi
{
    public int MaSoChiTietNoiSoi { get; set; }

    public string MaChiTietNoiSoi { get; set; } = null!;

    public int MaSoPhieuChiDinh { get; set; }

    public int NoiThucHien { get; set; }

    public int BsdocKetQua { get; set; }

    public int KtvthucHien { get; set; }

    public DateTime GioTiepNhan { get; set; }

    public DateTime GioThucHien { get; set; }

    public DateTime InLanDau { get; set; }

    public int MauKetQua { get; set; }

    public int MaThietBi { get; set; }

    public bool SinhThiet { get; set; }

    public bool Clotest { get; set; }
}
