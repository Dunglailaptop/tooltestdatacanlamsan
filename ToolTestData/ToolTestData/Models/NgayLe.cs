using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class NgayLe
{
    public int MaSoNgayLe { get; set; }

    public string MaNgayLe { get; set; } = null!;

    public string TenNgayLe { get; set; } = null!;

    public DateTime TuNgay { get; set; }

    public DateTime DenNgay { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
