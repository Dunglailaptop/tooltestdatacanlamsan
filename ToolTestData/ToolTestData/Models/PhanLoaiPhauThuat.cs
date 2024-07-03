using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class PhanLoaiPhauThuat
{
    public int MaSoPhanLoaiPhauThuat { get; set; }

    public string MaPhanLoaiPhauThuat { get; set; } = null!;

    public string TenPhanLoaiPhauThuat { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
