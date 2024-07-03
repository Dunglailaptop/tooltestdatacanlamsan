using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class LoaiThietBi
{
    public int MaSoLoaiThietBi { get; set; }

    public string MaLoaiThietBi { get; set; } = null!;

    public string TenLoaiThietBi { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
