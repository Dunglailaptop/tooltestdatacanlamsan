using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsPhieuYeuCauChinhSua
{
    public int MaSoPhieuYeuCauChinhSua { get; set; }

    public string MaPhieuYeuCauChinhSua { get; set; } = null!;

    public int? MaSoPhieuChiDinh { get; set; }

    public string LyDoChinhSua { get; set; } = null!;

    public int TrangThaiCs { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayCapNhat { get; set; }

    public DateTime NgayTao { get; set; }
}
