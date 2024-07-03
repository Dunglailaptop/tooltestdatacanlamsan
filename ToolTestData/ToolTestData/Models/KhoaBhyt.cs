using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class KhoaBhyt
{
    public int MaSoKhoaBhyt { get; set; }

    public string MaKhoaBhyt { get; set; } = null!;

    public string TenTiengViet { get; set; } = null!;

    public string TenTiengAnh { get; set; } = null!;

    public bool TrangThai { get; set; }

    public int NguoiTao { get; set; }

    public int NguoiSua { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
