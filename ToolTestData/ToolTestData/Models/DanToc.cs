using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class DanToc
{
    public int MaDanToc { get; set; }

    public string TenDanToc { get; set; } = null!;

    public bool TrangThai { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}
