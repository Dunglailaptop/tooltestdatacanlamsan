using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class LuotSuIn
{
    public int MaSoLuotSuIn { get; set; }

    public string MaLuotSuIn { get; set; } = null!;

    public DateTime NgayIn { get; set; }

    public int MaThamChieu { get; set; }

    public string MauThamChieu { get; set; } = null!;

    public int MaSoPhieuChiDinh { get; set; }

    public bool Logo { get; set; }

    public bool SaoChep { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
