using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DoiTuong
{
    public int MaSoDoiTuong { get; set; }

    public string MaDoiTuong { get; set; } = null!;

    public string TenDoiTuong { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
