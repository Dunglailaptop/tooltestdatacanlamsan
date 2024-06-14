using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class TinhThanh
{
    public int MaSoTinhThanh { get; set; }

    public string MaTinhThanh { get; set; } = null!;

    public string TenTinhThanh { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
