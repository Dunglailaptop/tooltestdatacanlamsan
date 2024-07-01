using System;
using System.Collections.Generic;

namespace ToolTestData.Models;

public partial class ClsNhmLogThuThuat
{
    public int MaSoLogThuThuat { get; set; }

    public int MaSoLoaiChePham { get; set; }

    public DateTime NgayTao { get; set; }

    public int NguoiDung { get; set; }

    public string HanhDong { get; set; } = null!;
}
