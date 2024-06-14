using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class PhieuPhauThuatThuThuat
{
    public int MaSoPhieuPhauThuatThuThuat { get; set; }

    public string MaPhieuPhauThuatThuThuat { get; set; } = null!;

    public string TruocPhauThuatThuThuat { get; set; } = null!;

    public string SauPhauThuatThuThuat { get; set; } = null!;

    public string PpphauThuatThuThuat { get; set; } = null!;

    public string LoaiPhauThuatThuThuat { get; set; } = null!;

    public string PpvoCam { get; set; } = null!;

    public string LuocDo { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
