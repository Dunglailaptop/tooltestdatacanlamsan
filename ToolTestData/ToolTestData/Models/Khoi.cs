using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class Khoi
{
    public int MaKhoi { get; set; }

    public int MaCoSo { get; set; }

    public string TenKhoi { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
