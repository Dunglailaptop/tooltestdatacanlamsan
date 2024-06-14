using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ThietBi
{
    public int MaSoThietBi { get; set; }

    public string MaThietBi { get; set; } = null!;

    public string TenThietBi { get; set; } = null!;

    public int MaSoLoaiThietBi { get; set; }

    public string? Series { get; set; }

    public int UuTien { get; set; }

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
