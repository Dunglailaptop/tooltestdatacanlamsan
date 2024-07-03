using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmPhanLoaiChePham
{
    public int MaSoPhanLoaiChePham { get; set; }

    public string MaPhanLoaiChePham { get; set; } = null!;

    public string TenPhanLoaiChePham { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
